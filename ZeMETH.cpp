// ZeMETH.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
#include <string>;

//Function to make the stars with dynamic lenght of longest line
string star(string _line, int _lineLength) {
        while (_line.length() < _lineLength - 1)
        {
            _line = _line + " ";
        }
        _line = _line + "*";



        return _line;
}

int main()
{
    string _line1;
    string _line2;
    string _line3;
    string _name;
    string _line4;
    string _topStars;
    int _totalStars;
    int _longestLine = 1;
    char _choice;

    do {
        _topStars = "";
        _name = "";
        cout << "Enter your name: " << endl;
        getline(cin, _name);

        _line1 = "* programming Assignment 1";
        _line2 = "* Computer Programming 1";
        _line3 = "*     Author: " + _name;
        _line4 = "* Due Date: Thursday, Jan. 24";


        if (_line4.length() > _line3.length()) {
            _longestLine = _line4.length() + 5;
        }
        else _longestLine = _line3.length() + 5;

        _line1 = star(_line1, _longestLine);
        _line2 = star(_line2, _longestLine);
        _line3 = star(_line3, _longestLine);
        _line4 = star(_line4, _longestLine);


        for (int i = 0; i < _longestLine; i++) {
            _topStars += "*";
        }

        cout << _topStars << endl;
        cout << _line1 << endl;
        cout << _line2 << endl;
        cout << _line3 << endl;
        cout << _line4 << endl;
        cout << _topStars << endl;

        cout << "Do you want to reset the program? (Y/N):" << endl;
        cin >> _choice;

        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    } while (_choice == 'Y' || _choice == 'y');

    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
