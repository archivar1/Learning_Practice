using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HsTable : MonoBehaviour
{
    public GameObject _input;
    public string NickName;
    public GameObject HighscoreTable;
    public Transform entryContainer;
    public Transform entryTemplate;
     private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;

      void Awake()
     {
       
        entryTemplate.gameObject.SetActive(false);
        highscoreEntryList = new List<HighscoreEntry>(){
          
           new HighscoreEntry {score = Random.Range(0, 1000), name = entryNick.NickText},
            new HighscoreEntry {score = Random.Range(0, 1000), name = "aaa"},
            new HighscoreEntry {score = Random.Range(0, 1000), name = "abb"},
            new HighscoreEntry {score = Random.Range(0, 1000), name = "john"},
            new HighscoreEntry {score = Random.Range(0, 1000), name = "ars"},
            new HighscoreEntry {score = Random.Range(0, 1000), name = "Max"},
            new HighscoreEntry {score = Random.Range(0, 1000), name = "Mix"},
      
        };
        
        for (int i=0; i<highscoreEntryList.Count; i++)
        {
            for (int j = i+1;j<highscoreEntryList.Count; j++ )
            {
                if (highscoreEntryList[j].score >highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscoreEntryList[i];
                    highscoreEntryList[i]= highscoreEntryList[j];
                    highscoreEntryList[j]= tmp;
                }
            }
        }
        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscoreEntryList){
            CreatingHighscoreEntryTransform (highscoreEntry, entryContainer, highscoreEntryTransformList);
        }
       
     }
      void Update()
     {
        
        HighscoreTable.SetActive(false);

         if (Input.GetKey(KeyCode.Tab))
        {
        HighscoreTable.SetActive(true);
        }
     }
     private void CreatingHighscoreEntryTransform (HighscoreEntry highscoreEntry, Transform container, List <Transform> transformList)
        {
            float templateHeight = 10f;
            Transform entryTransform = Instantiate(entryTemplate, container);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count); 
            entryTransform.gameObject.SetActive(true);

            int rank = transformList.Count+1;
           
            int score = highscoreEntry.score;
            
            string name = highscoreEntry.name;
            
            entryTransform.Find("posText").GetComponent<Text>().text = rank.ToString();
            entryTransform.Find("scoreText").GetComponent<Text>().text =score.ToString();
            entryTransform.Find("nameText").GetComponent<Text>().text =name;

            transformList.Add(entryTransform);
        }

    private class HighscoreEntry
    {
        public int score;
        public string name;
    }
}
