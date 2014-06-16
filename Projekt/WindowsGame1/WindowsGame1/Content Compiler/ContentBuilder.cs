
///Content Builder klasa za run-time kompajliranje FBX i PNG resursa
///u XNA kompatibilne XNB formate i učitavanje u Renderer.
///
///Preuzeto sa Microsoftovog libraryja:
///http://xbox.create.msdn.com/en-US/education/catalog/sample/winforms_series_2
///
///Klasa je modificirana za potrebe našeg projekta.

///Original code:
///=========================
//-----------------------------------------------------------------------------
// ContentBuilder.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------


using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using System.Windows.Forms;


namespace WindowsGame1
{
   
    public class ContentBuilder:IDisposable
    {
        #region Fields


        // What importers or processors should we load?
        const string xnaVersion = ", Version=4.0.0.0, PublicKeyToken=842cf8be1de50553";

        static string[] pipelineAssemblies =
        {
            "Microsoft.Xna.Framework.Content.Pipeline.FBXImporter" + xnaVersion,
            "Microsoft.Xna.Framework.Content.Pipeline.TextureImporter" + xnaVersion,

        };


        // MSBuild objects used to dynamically build content.
        Project buildProject;
        ProjectRootElement projectRootElement;
        BuildParameters buildParameters;
        List<ProjectItem> projectItems = new List<ProjectItem>();
     


        // Temporary directories used by the content build.
        string buildDirectory;
        string processDirectory;
        string baseDirectory;
        public string absolutePath;


        // Generate unique directory names if there is more than one ContentBuilder.
        static int directorySalt;


        // Have we been disposed?
        bool isDisposed;


        #endregion

        #region Properties


        /// <summary>
        /// Gets the output directory, which will contain the generated .xnb files.
        /// </summary>
        public string OutputDirectory
        {
            get { return Path.Combine(buildDirectory, "bin/Content"); }
        }


        #endregion

        #region Initialization


        /// <summary>
        /// Creates a new content builder.
        /// </summary>
        public ContentBuilder()
        {
            CreateTempDirectory();
            CreateBuildProject();
        }


        /// <summary>
        /// Finalizes the content builder.
        /// </summary>
        ~ContentBuilder()
        {
            Dispose(false);
        }


        /// <summary>
        /// Disposes the content builder when it is no longer required.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// Implements the standard .NET IDisposable pattern.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if ( !isDisposed )
            {
                isDisposed = true;

                //DeleteTempDirectory();
            }
        }


        #endregion

        #region MSBuild


        /// <summary>
        /// Creates a temporary MSBuild content project in memory.
        /// </summary>
        void CreateBuildProject()
        {
            string projectPath = Path.Combine(buildDirectory, "content.contentproj");

            string outputPath = buildDirectory;
            absolutePath = outputPath;

            if (File.Exists(projectPath))
                File.Delete(projectPath);

            // Create the build project.
            projectRootElement = ProjectRootElement.Create(projectPath);

            // Include the standard targets file that defines how to build XNA Framework content.
            projectRootElement.AddImport("$(MSBuildExtensionsPath)\\Microsoft\\XNA Game Studio\\" +
                                         "v4.0\\Microsoft.Xna.GameStudio.ContentPipeline.targets");
          
            buildProject = new Project(projectRootElement);
            

            buildProject.SetProperty("XnaPlatform", "Windows");
            buildProject.SetProperty("XnaProfile", "Reach");
            buildProject.SetProperty("XnaFrameworkVersion", "v4.0");
            buildProject.SetProperty("Configuration", "Release");
            buildProject.SetProperty("OutputPath", outputPath);

            // Register any custom importers or processors.
            foreach ( string pipelineAssembly in pipelineAssemblies )
            {
                buildProject.AddItem("Reference", pipelineAssembly);
            }

         
            buildParameters = new BuildParameters(ProjectCollection.GlobalProjectCollection);
           
        }


        /// <summary>
        /// Adds a new content file to the MSBuild project. The importer and
        /// processor are optional: if you leave the importer null, it will
        /// be autodetected based on the file extension, and if you leave the
        /// processor null, data will be passed through without any processing.
        /// </summary>
        public void Add(string filename, string name, string importer, string processor)
        {
            ProjectItem item = buildProject.AddItem("Compile", filename)[0];

            item.SetMetadataValue("Link", Path.GetFileName(filename));
            item.SetMetadataValue("Name", name);

            if ( !string.IsNullOrEmpty(importer) )
                item.SetMetadataValue("Importer", importer);

            if ( !string.IsNullOrEmpty(processor) )
                item.SetMetadataValue("Processor", processor);

            projectItems.Add(item);
        }


        /// <summary>
        /// Removes all content files from the MSBuild project.
        /// </summary>
        public void Clear()
        {
            buildProject.RemoveItems(projectItems);

            projectItems.Clear();
        }


        /// <summary>
        /// Builds all the content files which have been added to the project,
        /// dynamically creating .xnb files in the OutputDirectory.
        /// Returns an error message if the build fails.
        /// </summary>
        public string Build()
        {
            // Create and submit a new asynchronous build request.
            BuildManager.DefaultBuildManager.BeginBuild(buildParameters);

            BuildRequestData request = new BuildRequestData(buildProject.CreateProjectInstance(), new string[0]);
            BuildSubmission submission = BuildManager.DefaultBuildManager.PendBuildRequest(request);

            submission.ExecuteAsync(null, null);

            // Wait for the build to finish.
            submission.WaitHandle.WaitOne();

            BuildManager.DefaultBuildManager.EndBuild();

            // If the build failed, return an error string.
            if ( submission.BuildResult.OverallResult == BuildResultCode.Failure )
            {
               // return string.Join("\n", errorLogger.Errors.ToArray());
            }
            
            return null;
        }


        #endregion

        #region Temp Directories


        /// <summary>
        /// Creates a temporary directory in which to build content.
        /// </summary>
        void CreateTempDirectory()
        {
            string path = Application.ExecutablePath;
            DirectoryInfo info = System.IO.Directory.GetParent(path);

            buildDirectory = info.FullName;

            // Create our temporary directory.
            Directory.CreateDirectory(buildDirectory);

            //PurgeStaleTempDirectories();
        }

        #endregion
    }
}
