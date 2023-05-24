using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public InputField inputField;

    private void Start()
    {
        // Получаем компонент кнопки и подписываемся на событие ее нажатия
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    public  void OnButtonClick()
    {
        string inputValue = inputField.text;
        Debug.Log("Значение поля ввода: " + inputValue);
    }
}