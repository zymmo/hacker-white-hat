
#include <iostream>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>


using namespace std;
void question();
int main()
{
	question();

	return 0;
}
void question()

{
	int answer = 0;
	int number1 = 0, number2 = 0;
	int correctAnswer;
	srand(time(NULL));
	number1 = rand() % 9 + 1;
	number2 = rand() % 9 + 1;
	cout << "How much is " << number1 << " Times " << number2<<" :";
	cin >> answer;
	correctAnswer = number1 * number2;
	if (answer == correctAnswer) {
		cout << "Very good";
	}


}
