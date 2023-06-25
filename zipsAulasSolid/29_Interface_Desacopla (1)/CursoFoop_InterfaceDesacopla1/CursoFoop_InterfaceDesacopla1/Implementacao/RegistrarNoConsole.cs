using System;
using CursoFoop_InterfaceDesacopla1.Interface;

namespace CursoFoop_InterfaceDesacopla1.Implementacao
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"info : {mensagem}");
        }
    }
}
