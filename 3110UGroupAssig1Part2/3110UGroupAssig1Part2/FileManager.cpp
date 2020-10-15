#include "FileManager.h"

//This function will write the saved values to a text file
void FileManager::WriteFile(std::string fileName)
{
	//Open the file
	write.open(fileName);
	//If the file is open
	if (write.is_open())
	{
		//Write each value to the file
		write << getX() << "\n";
		write << getY() << "\n";
		write << getZ() << "\n";

		//Close the file
		write.close();
	}
}

//This function will read the text file and assign the saved values to the objects position
void FileManager::ReadFile(std::string fileName)
{
	float posVal;
	std::string line;
	//Open the file
	read.open(fileName);

	int counter = 0;

	//If the file is open
	if (read.is_open())
	{
		//Go through each line in the file
		while (std::getline(read, line))
		{
			//Go through each line in the file and covert the string of the number into a float
			if (counter == 0)
			{
				posVal = std::stof(line);
				setX(posVal);
			}
			else if (counter == 1)
			{
				posVal = std::stof(line);
				setY(posVal);
			}
			else if (counter == 2)
			{
				posVal = std::stof(line);
				setZ(posVal);
			}

			//Increment the counter to assign the values to the next variable
			counter++;
		}
		//Close the file
		read.close();
	}
}

//Saves the values to variables and calls the writer
void FileManager::SavePosition(float posX, float posY, float posZ)
{
	//Store the values passed into the variables
	setX(posX);
	setY(posY);
	setZ(posZ);

	//Call the file writer
	WriteFile("save.txt");//, this);
}

//Calls the reader
void FileManager::LoadPosition()
{
	ReadFile("save.txt");
}

void FileManager::setX(float posX)
{
	X = posX;
}

void FileManager::setY(float posY)
{
	Y = posY;
}

void FileManager::setZ(float posZ)
{
	Z = posZ;
}

float FileManager::getX()
{
	return X;
}

float FileManager::getY()
{
	return Y;
}

float FileManager::getZ()
{
	return Z;
}