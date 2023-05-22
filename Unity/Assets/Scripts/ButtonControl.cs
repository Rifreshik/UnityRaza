using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuButton : MonoBehaviour
{
    public InputField input;
    private DB db;
   public void Poisk()
   {
    SceneManager.LoadScene(1);
   }
    public void Button()
    {
        db.SaveData(input.text);
    }
}
