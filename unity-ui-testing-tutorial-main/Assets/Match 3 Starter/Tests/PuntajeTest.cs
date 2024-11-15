using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeTest
{
    private GUIManager guiManager;
    private Text scoreText;
    // A Test behaves as an ordinary method
    [SetUp]

    public void SetUp()
    {
        var guiManagerObject = new GameObject("GUIManager");
        guiManager = guiManagerObject.AddComponent<GUIManager>();

        var scoreTextObject = new GameObject("ScoreText");
        scoreText = scoreTextObject.AddComponent<Text>();
        guiManager.scoreTxt = scoreText;
    }

    [TearDown]

    public void TearDown() 
    {
        Object.DestroyImmediate(guiManager.gameObject);
        Object.DestroyImmediate(scoreText.gameObject);
    }
    [Test]

    public void ScoreCambiaCorrectamente()
    {
        int InitialScore = 0;
        guiManager.Score = InitialScore;

        Assert.AreEqual(InitialScore, guiManager.Score);
        Assert.AreEqual(InitialScore.ToString(), guiManager.scoreTxt.text);

        int newScore = 100;
        guiManager.Score = newScore;

        Assert.AreEqual(newScore, guiManager.Score);
        Assert.AreEqual(newScore.ToString(), guiManager.scoreTxt.text);
    }
}
