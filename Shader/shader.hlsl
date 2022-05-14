float Scale;
float iTime;

float2 Offset;

float4 main(in float2 uv : TEXCOORD0) : SV_TARGET
{
    uv.y += iTime;
    float x = sin(uv.x * Scale + Offset.x) - (uv.y * Scale);
    return float4(x, 0, 0.0, 1);
}