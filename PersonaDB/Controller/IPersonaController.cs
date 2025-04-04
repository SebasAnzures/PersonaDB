using PersonaDB.Model;

namespace PersonaDB.Controller
{
    internal interface IPersonaController
    {
        List<Social> Leer();
        bool Insertar(Social social);
    }
}