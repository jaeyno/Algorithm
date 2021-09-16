using System.Collections.Generic;
using System;

public class Program {
    public string TournamentWinner(List<List<string>> competitions, List<int> results) {
        
        string currentWinningTeam = "";
        
        //create a empty dictionary to record the scores for each team
        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores[currentWinningTeam] = 0;

        for (int i = 0; i <= competitions.Count; i++) {
            string homeTeam = competitions[i][0];
            string awayTeam = competitions[i][1];
            string winningTeam = (results[i] == 1) ? homeTeam : awayTeam;

            updateScore(winningTeam, 3, scores);

            if (scores[winningTeam] > scores[currentWinningTeam]) {
                currentWinningTeam = winningTeam;
            }
        }
        return currentWinningTeam;
    }

    public void updateScore(string winningTeam, int score, Dictionary<string, int> scores) {
        if (!scores.ContainsKey(winningTeam)) {
            scores[winningTeam] = 0;
        }

        scores[winningTeam] = scores[winningTeam] + score;
    }
}
//Time complexity is O(n) & Space complexity is O(k) - k is the number of teams