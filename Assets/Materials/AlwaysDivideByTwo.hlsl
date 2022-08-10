//UNITY_SHADER_NO_UPGRADE
#ifndef MYHLSLINCLUDE_INCLUDED
#define MYHLSLINCLUDE_INCLUDED

void AlwaysDivideByTwo_float(float A, float B, out float Out)
{
    Out = (A + B) / 2;
}
#endif //MYHLSLINCLUDE_INCLUDED