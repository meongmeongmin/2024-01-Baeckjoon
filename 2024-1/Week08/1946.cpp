// 코드 리뷰
// https://mmmin14.tistory.com/30

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

    int t;
    cin >> t;
    
    vector<vector<pair<int, int>>> test(t);
    for (int i = 0; i < t; i++)
    {
        int n;
        cin >> n;
        
        test[i].reserve(n);
        for (int j = 0; j < n; j++)
        {
            int docsRanking, interviewRanking;
            cin >> docsRanking >> interviewRanking;
            test[i].push_back(make_pair(docsRanking, interviewRanking));
        }
        
        sort(test[i].begin(), test[i].end());
    }

    for (const auto& applicants : test)
    {
        int count = 0;
        int min = applicants.size();
        for (const auto& applicant : applicants)
        {
            if (min >= applicant.second)
            {
                count++;
                min = applicant.second;
            }
        }

        cout << count << "\n";
    }

    return 0;
}
