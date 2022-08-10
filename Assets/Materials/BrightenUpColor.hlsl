//UNITY_SHADER_NO_UPGRADE
#ifndef MYHLSLINCLUDE_INCLUDED
#define MYHLSLINCLUDE_INCLUDED

void BrightenUpColor_float(float4 A, float4 B, out float4 Out)
{
    Out = (A + B) * 2;
}
#endif //MYHLSLINCLUDE_INCLUDED