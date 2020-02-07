using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textcontrol : MonoBehaviour
{
    public Text text;
    enum states { chamber, corridor, saloon, kitchen, attic, outside, sea };
    states mojstan = states.chamber;
    public Sprite ciemno;
    public Sprite kor;
    public Sprite gora;
    public Sprite kuch;
    public Sprite sal;
    public Sprite zew;
    public Image img;

    private void Start()
    {

    }
    private void Update()
    {
        if (mojstan == states.chamber)
            komnata();
        else if (mojstan == states.corridor)
            korytarz();
        else if (mojstan == states.kitchen)
            kuchnia();
        else if (mojstan == states.attic)
            dach();
        else if (mojstan == states.saloon)
            salon();
        else if (mojstan == states.outside)
            zewnatrz();
        else if (mojstan == states.sea)
            morze();
    }

    private void komnata()
    {
        img.sprite = ciemno;

        text.text = "Jesteś w ciemnej komnacie, " +
            "a przed tobą są jakieś drzwi... \n" +
            "Kliknij K aby przez nie przejść \n" +
            "Jeżeli gra poprosi o liczby, \n" +
            "wpisz je z klawiatury numerrycznej.";
        if (Input.GetKeyDown(KeyCode.K))
        {
            mojstan = states.corridor;

        }
    }
    private void korytarz()
    {
        img.sprite = kor;
        text.text = "Wychodzisz na korytarz.\n" +
            "Lekkie światło lamp odsłania dla Twoich oczu kilkoro innych drzwi\n" +
            "Kliknij 1 aby wejść do pierwszych \n" +
            "Kliknij 2 aby wejść do drugich \n" +
            "Kliknij 3 aby wejść do trzecich \n" +
            "Kliknij 4 aby wejść do czwartych \n" +
            "Kliknij 0 aby wrócić";
        if (Input.GetKeyDown(KeyCode.Keypad0))
        { mojstan = states.chamber; }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        { mojstan = states.kitchen; }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        { mojstan = states.attic; }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        { mojstan = states.saloon; }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        { mojstan = states.outside; }
    }
    private void kuchnia()
    {
        img.sprite = kuch;
        text.text = "Czujesz zapach zgnilizny" +
            "utrzymujacy sie w powietrzu.\n" +
            "Wydaje ci się że kiedyś musiała to być kuchnia \n" +
            "Kliknij 0 aby wrócić";
        if (Input.GetKeyDown(KeyCode.Keypad0))
        { mojstan = states.corridor; }
    }
    private void dach()
    {
        img.sprite = gora;
        text.text = "Wchodzisz po trzeszących schodach na zgnite poddasze \n" +
            "Wszystkie okiennice są przeżarte pewnie przez robaki. \n" +
            "Czujesz jednak świeżę morskie powietrze \n" +
            "Kliknij 0 aby wrócić ";
        if (Input.GetKeyDown(KeyCode.Keypad0))
        { mojstan = states.corridor; }
    }
    private void salon()
    {
        img.sprite = sal;
        text.text = "Zerkając przez próg widzisz niegdysiejsze " +
            "centrum tego domu. \n" +
            "Witają Cię łowieckie trofea i bibliteka pełna książek. \n" +
            "Widzisz chyba drzwi prowadzące na dwór. \n" +
            "Kliknij 0 aby wrócić \n" +
            "Kliknij 1 aby iść na dwór \n";
        if (Input.GetKeyDown(KeyCode.Keypad0))
        { mojstan = states.corridor; }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        { mojstan = states.outside; }
    }
    private void zewnatrz()
    {
        img.sprite = zew;
        text.text = "Wychodzisz na dwór\n" +
            "Wita Cię czarna otchłań morza," +
            "która wydaje Ci się tajemiczą i niebezpieczną\n" +
            "przestrzenią na którą lepiej dłużej nie patrzyć\n" +
            "W pobliżu widzisz łodkę z wiosłami\n" +
            "Kliknij 0 aby do niej wejść" +
            "Kliknij 1 aby wrócić do domu";
        if (Input.GetKeyDown(KeyCode.Keypad0))
        { mojstan = states.sea; }
    }
    private void morze()
    {

    }
}

