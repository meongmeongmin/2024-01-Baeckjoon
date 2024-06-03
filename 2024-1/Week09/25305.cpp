// 코드 리뷰
// https://mmmin14.tistory.com/31

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() 
{
    #pragma region I/O
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    #pragma endregion

    int n, k;
    cin >> n >> k;

    vector<int> score(n);
    for (int i = 0; i < n; i++)
        cin >> score[i];

    sort(score.begin(), score.end(), greater<int>());
    cout << score[k - 1];

    return 0;
}
