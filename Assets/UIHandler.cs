using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIHandler : MonoBehaviour
{
    public TMP_Text hpText, strText, dexText, conText, intText, wisText, chaText/*, nameText*/, finalText;
    public TMP_InputField nameText;
    public string actualRealRace, actualRealClass, actualRealAlignment;
    public GameObject panel, errorPanel;

    public void ShowHP(float hp)
    {
        hpText.text = hp.ToString();
    }
    public void ShowSTR(float str)
    {
        strText.text = str.ToString();
    }
    public void ShowDEX(float dex)
    {
        dexText.text = dex.ToString();
    }
    public void ShowCON(float con)
    {
        conText.text = con.ToString();
    }
    public void ShowINT(float intel)
    {
        intText.text = intel.ToString();
    }
    public void ShowWIS(float wis)
    {
        wisText.text = wis.ToString();
    }
    public void ShowCHA(float cha)
    {
        chaText.text = cha.ToString();
    }
    public void NameText(string name)
    {
        nameText.text = name;
    }
    public void RaceSelection(Int32 race)
    {
        switch (race)
        {
            case 0:
                actualRealRace = "Dragonborn";
                break;
            case 1:
                actualRealRace = "Dwarf";
                break;
            case 2:
                actualRealRace = "Elf";
                break;
            case 3:
                actualRealRace = "Gnome";
                break;
            case 4:
                actualRealRace = "Half-Elf";
                break;
            case 5:
                actualRealRace = "Halfling";
                break;
            case 6:
                actualRealRace = "Half-Orc";
                break;
            case 7:
                actualRealRace = "Human";
                break;
            case 8:
                actualRealRace = "Tiefling";
                break;
            default:
                break;
        }
    }
    public void ClassSelection(Int32 selectedClass)
    {
        switch(selectedClass)
        {
            case 0:
                actualRealClass = "Barbarian";
                break;
            case 1:
                actualRealClass = "Bard";
                break;
            case 2:
                actualRealClass = "Cleric";
                break;
            case 3:
                actualRealClass = "Druid";
                break;
            case 4:
                actualRealClass = "Fighter";
                break;
            case 5:
                actualRealClass = "Monk";
                break;
            case 6:
                actualRealClass = "Paladin";
                break;
            case 7:
                actualRealClass = "Ranger";
                break;
            case 8:
                actualRealClass = "Rogue";
                break;
            case 9:
                actualRealClass = "Sorcerer";
                break;
            case 10:
                actualRealClass = "Warlock";
                break;
            case 11:
                actualRealClass = "Wizard";
                break;
            default:
                break;
        }
    }
    public void AlignmentSelection(Int32 alignment)
    {
        switch (alignment)
        {
            case 0:
                actualRealAlignment = "Lawful Good";
                break;
            case 1:
                actualRealAlignment = "Lawful Neutral";
                break;
            case 2:
                actualRealAlignment = "Lawful Evil";
                break;
            case 3:
                actualRealAlignment = "Neutral Good";
                break;
            case 4:
                actualRealAlignment = "True Neutral";
                break;
            case 5:
                actualRealAlignment = "Neutral Evil";
                break;
            case 6:
                actualRealAlignment = "Chaotic Good";
                break;
            case 7:
                actualRealAlignment = "Chaotic Neutral";
                break;
            case 8:
                actualRealAlignment = "Chaotic Evil";
                break;
            default:
                break;
        }
    }
    public void SheetCompleted()
    {
        if (string.IsNullOrEmpty(nameText.text))
        {
            errorPanel.SetActive(true);
        }
        else
        {
            panel.SetActive(true);
            finalText.text = "Your character's name is " + nameText.text + ". Their race is " + actualRealRace + " and their class is " + actualRealClass + ". They are " + actualRealAlignment + ". Their stat points are; Hit points: " + hpText.text + ", Strength: " + strText.text + ", Dexterity: " + dexText.text + ", Constitution: " + conText.text + ", Intelligence: " + intText.text + ", Wisdom: " + wisText.text + ", Charisma: " + chaText.text + ". Your character is ready.";
        }
    }
    public void BackButton()
    {
        panel.SetActive(false);
        errorPanel.SetActive(false);
    }
    private void Start()
    {
        actualRealClass = "Barbarian";
        actualRealRace = "Dragonborn";
        actualRealAlignment = "Lawful Good";
        panel.SetActive(false);
    }
    private void Update()
    {
        Debug.Log("Your character's name is " +  nameText.text + ". Their race is " + actualRealRace + " and their class is " + actualRealClass + ". They are " + actualRealAlignment + ". Their stat points are; Hit points: " + hpText.text + ", Strength: " + strText.text + ", Dexterity: " + dexText.text + ", Constitution: " + conText.text + ", Intelligence: " + intText.text + ", Wisdom: " + wisText.text + ", Charisma: " + chaText.text + ". Your character is ready.");
    }
}
