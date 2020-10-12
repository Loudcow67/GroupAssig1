using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DLLManager : MonoBehaviour
{
    const string DLL_NAME = "3110UGroupAssig1Part2";

    [DllImport(DLL_NAME)]
    private static extern void WriteFile(string fileName);

    [DllImport(DLL_NAME)]
    private static extern void ReadFile(string fileName);

    [DllImport(DLL_NAME)]
    private static extern void SavePosition(float posX, float posY, float posZ);

    [DllImport(DLL_NAME)]
    private static extern void LoadPosition();

    [DllImport(DLL_NAME)]
    private static extern void setX(float posX);

    [DllImport(DLL_NAME)]
    private static extern void setY(float posY);

    [DllImport(DLL_NAME)]
    private static extern void setZ(float posZ);

    [DllImport(DLL_NAME)]
    private static extern float getX();

    [DllImport(DLL_NAME)]
    private static extern float getY();

    [DllImport(DLL_NAME)]
    private static extern float getZ();

    public void writeFile(string FileName)
    {
        WriteFile(FileName);
    }

    public void readFile(string FileName)
    {
        ReadFile(FileName);
    }

    public void savePosition(float Xpos, float Ypos, float Zpos)
    {
        SavePosition(Xpos, Ypos, Zpos);
    }

    public void loadPosition()
    {
        LoadPosition();
    }

    public void setXpos(float Xpos)
    {
        setX(Xpos);
    }

    public void setYPos(float Ypos)
    {
        setY(Ypos);
    }

    public void setZPos(float Zpos)
    {
        setZ(Zpos);
    }

    public float getXpos()
    {
        return getX();
    }

    public float getYPos()
    {
        return getY();
    }

    public float getZPos()
    {
        return getZ();
    }
}
