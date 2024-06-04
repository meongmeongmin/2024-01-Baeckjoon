// 코드 리뷰
// https://mmmin14.tistory.com/32

#include <iostream>

using namespace std;

int solve(string preBulb, string bulb, bool press0Btn = false)
{
    int count = 0;
    if (press0Btn)
    {
        count++;
        preBulb[0] = preBulb[0] == '0' ? '1' : '0';
        preBulb[1] = preBulb[1] == '0' ? '1' : '0';
    }

    for (int i = 0; i < bulb.size() - 1; i++)
    {
        if (preBulb[i] != bulb[i])
        {
            count++;
            preBulb[i] = preBulb[i] == '0' ? '1' : '0';
            preBulb[i + 1] = preBulb[i + 1] == '0' ? '1' : '0';

            if (i + 2 <= bulb.size())
                preBulb[i + 2] = preBulb[i + 2] == '0' ? '1' : '0';
        }
    }

    count = preBulb == bulb ? count : -1;
    return count;
}

int main()
{
    #pragma region I/O
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    #pragma endregion

    int n;
    cin >> n;
    
    string preBulb, bulb;
    cin >> preBulb >> bulb;
    
    int count = solve(preBulb, bulb);
    int count2 = solve(preBulb, bulb, true);

    if (count != -1 && count2 != -1)
        cout << min(count, count2);
    else if (count == -1)
        cout << count2;
    else if (count2 == -1)
        cout << count;
    else
        cout << -1;
}
