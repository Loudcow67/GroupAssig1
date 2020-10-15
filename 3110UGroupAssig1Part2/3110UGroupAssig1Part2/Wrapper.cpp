#include "Wrapper.h"
FileManager fileMan;

void SavePosition(float posX, float posY, float posZ)
{
	return fileMan.SavePosition(posX, posY, posZ);
}

void LoadPosition()
{
	return fileMan.LoadPosition();
}

float getX()
{
	return fileMan.getX();
}

float getY()
{
	return fileMan.getY();
}

float getZ()
{
	return fileMan.getZ();
}
