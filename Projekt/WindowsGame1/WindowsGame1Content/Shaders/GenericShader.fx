float4x4 World;
float4x4 View;
float4x4 Projection;

texture2D tex0;

sampler2D smpl = sampler_state
{
	texture = <tex0>;
};


struct VertexShaderInput
{
    float4 Position : POSITION0;
	float2 texCoord : TEXCOORD0;
  
};

struct VertexShaderOutput
{
    float4 Position : POSITION0;
	float2 texCoord : TEXCOORD0;
  
};

VertexShaderOutput VertexShaderFunction(VertexShaderInput input)
{
    VertexShaderOutput output;

    float4 worldPosition = mul(input.Position, World);
    float4 viewPosition = mul(worldPosition, View);
    output.Position = mul(viewPosition, Projection);
 
	output.texCoord = input.texCoord;

    return output;
}

float4 PixelShaderFunction(VertexShaderOutput input) : COLOR0
{
    return tex2D(smpl, input.texCoord);
}

technique Technique1
{
    pass Pass1
    {

        VertexShader = compile vs_2_0 VertexShaderFunction();
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
