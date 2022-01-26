#include <iostream>
#include <stack>
using namespace std;
//You have to create functions above main. C++ won't read any functions under main;
//You no longer need to add public static before return type in visual studio 2022. 
string AskForName()
{
    cout << "What is your name?\n";
    string name;
    cin >> name;
    return name;
}

void MakingAStack()
{
    stack<int> stack1;
    stack<int> stack2;
    stack.push(5);
    stack.push(15);
    stack.push(100);

    stack2.push(stack1.pop());
}



int main()
{
    // this how you set a variable from a return type of a function
    string Name = AskForName();
    //this is how you call a variable in a print statement
    cout << "So your name is " + Name;
}

