using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Prefs : MonoBehaviour
{
    // Start is called before the first frame update
   public void SaveUserData(string useridPassado, string usernamePassado, string emailPassado, string birthDatePassado, string genderPassado, string photoPassado)
    {
        Debug.Log("Estou a salvar");

        PlayerPrefs.SetString("userid", useridPassado);
        PlayerPrefs.SetString("username", usernamePassado);
        PlayerPrefs.SetString("email", emailPassado);
        PlayerPrefs.SetString("birthDate", birthDatePassado);
        PlayerPrefs.SetString("gender", genderPassado);
        PlayerPrefs.SetString("photo", photoPassado);
        

        PlayerPrefs.Save();
    }

    // Update is called once per frame
   public User GetUserData ()
    {
        User userToReturn = new User(PlayerPrefs.GetString("userid"), PlayerPrefs.GetString("username"), PlayerPrefs.GetString("email"), PlayerPrefs.GetString("birthDate"), PlayerPrefs.GetString("gender"), PlayerPrefs.GetString("photo"));
        return userToReturn;
    }
}