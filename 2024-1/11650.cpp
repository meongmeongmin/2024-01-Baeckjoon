// 코드 리뷰
// https://mmmin14.tistory.com/28

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

    int n;
    cin >> n;
    vector<pair<int, int>> coordinates;
    coordinates.reserve(n);
    for (int i = 0; i < n; i++) 
    {
        int x, y;
        cin >> x >> y;
        coordinates.push_back(make_pair(x, y));
    }

    sort(coordinates.begin(), coordinates.end());

    for (const auto& xy : coordinates)
        cout << xy.first << " " << xy.second << "\n";
    
    return 0;
}
