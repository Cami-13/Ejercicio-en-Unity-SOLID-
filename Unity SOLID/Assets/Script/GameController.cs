using UnityEngine;
using UnityEngine.InputSystem; 

public interface IFruit
{
    void DarEnergia(Player player);
}

public class Player
{
    public int energia = 50;
    public int vision = 50;
    public int recuperacionMuscular = 50;

    public void ComerFruta(IFruit fruta)
    {
        fruta.DarEnergia(this);
    }

    public void MostrarEstado()
    {
        Debug.Log($"Energía: {energia}, Visión: {vision}, Recuperación muscular: {recuperacionMuscular}");
    }
}

public class Banana : IFruit
{
    public int energiaExtra = 10;
    public int recuperacionExtra = 15;

    public void DarEnergia(Player player)
    {
        player.energia += energiaExtra;
        player.recuperacionMuscular += recuperacionExtra;
        Debug.Log("Comí una Banana: energía y recuperación muscular mejoradas.");
    }
}

public class Frutilla : IFruit
{
    public int energiaExtra = 5;
    public int visionExtra = 20;

    public void DarEnergia(Player player)
    {
        player.energia += energiaExtra;
        player.vision += visionExtra;
        Debug.Log("Comí una Frutilla: energía y visión mejoradas.");
    }
}


public class GameController : MonoBehaviour
{
    private Player jugador;
    private IFruit[] frutas;

    void Start()
    {
        jugador = new Player();
        frutas = new IFruit[] { new Banana(), new Frutilla() };

        Debug.Log("Estado inicial del jugador:");
        jugador.MostrarEstado();
        Debug.Log("Presiona SPACE para comer una fruta aleatoria.");
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (frutas.Length == 0) return;

            int indice = Random.Range(0, frutas.Length);
            jugador.ComerFruta(frutas[indice]);
            jugador.MostrarEstado();
        }
    }
}

