// 코드 리뷰
// https://mmmin14.tistory.com/29

#include <iostream>

using namespace std;

int main() 
{
    #pragma region I/O
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    #pragma endregion

    int m, d;
    cin >> m >> d;

    int month[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    const char* dayWeek[7] = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
    int day = d;
    for (int i = 1; i < m; i++)
        day += month[i - 1];

    cout << dayWeek[day % 7];
    return 0;
}
