// Test.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
//You have to create functions above main. C++ won't read any functions under main;
string AskForName()
{
    cout << "What is your name?\n";
    string name;
    cin >> name;
    return name;
}

int main()
{
    string Name = AskForName();
    cout << "So your name is " + Name;
}

