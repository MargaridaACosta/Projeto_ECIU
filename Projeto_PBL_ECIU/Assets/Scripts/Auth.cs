using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Auth : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField email_input;
    public InputField password_input;
    public GameObject nextPage;
    public string LogInState;
    public GameObject Loading;
    public void Login()
    {

        LogInState = "Waiting";
        StopCoroutine("CheckState");
        StartCoroutine("CheckState");

        Debug.Log("Login realizado com sucesso");
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        string email = email_input.text.ToString();
        string password = password_input.text.ToString();

        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
         {
             if (task.IsCanceled)
             {
                 LogInState = "NotDone";
                 Debug.Log("SignInWithEmailAndPasswordAsync was canceled.");
                 return;
             }
             if (task.IsFaulted)
             {
                 LogInState = "NotDone";
                 Debug.LogError(task.Exception.GetBaseException().Message);
                 return;
             }

             LogInState = "Done";
             
             Firebase.Auth.FirebaseUser newUser = task.Result;
             Debug.LogFormat("User signed in successfully: {0} ({1})", 
                 newUser.DisplayName, newUser.UserId);
             Debug.Log("Autentificação Feita");
    



         });


        if (LogInState == "Done")
        {
            SceneManager.LoadScene("App Layout");
            
        }

    }

    IEnumerator CheckState()
    {

        for (; ; )
        {

            if (LogInState == "Done")
            {
                Loading.SetActive(false);
                Debug.Log("Done");
                gameObject.SetActive(false);
                SceneManager.LoadScene("App Layout");
                break;
            }
            if (LogInState == "NotDone")
            {
                Loading.SetActive(false);
                Debug.Log("Not Done");
                break;

            }

            if (LogInState == "Waiting")
            {
                if (!Loading.activeSelf) Loading.SetActive(true);

                    Debug.Log("Waiting");
                
            }


            yield return new WaitForSeconds(.1f);

        }

        


    }
    }