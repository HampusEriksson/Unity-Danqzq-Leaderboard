using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;
public class LeaderBoard : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private string leaderboardKey = "165c9b8fdaa33f77b9d640a0a1aa54c41c58c0d6727f4afdbe981e8750196b01";

    public void GetLeaderBoard()
    {
        LeaderboardCreator.GetLeaderboard(leaderboardKey, (leaderboard) =>
        {
            scoreText.text = "";
            foreach (var item in leaderboard)
            {
                Debug.Log(item.Username + " : " + item.Score);
                scoreText.text += item.Username + " : " + item.Score + "\n";
            }
        });
    }

    public void SetLeaderBoardEntry()
    {
        string username = "Dan";
        int score = Random.Range(0, 100);
        LeaderboardCreator.UploadNewEntry(leaderboardKey, username, score);
        GetLeaderBoard();
    }
}
