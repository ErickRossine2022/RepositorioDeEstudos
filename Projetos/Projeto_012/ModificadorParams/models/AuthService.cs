using System;
using System.Collections.Generic;

namespace ModificadorParams
{
    // Exemplo: serviço de autenticação simples que demonstra o uso de `params`
    // para registrar múltiplos usuários de uma só vez usando tuplas.
    // Nota: este é um exemplo didático; em produção nunca armazene senhas em texto puro.
    class AuthService
    {
        // Cria uma Propiedade Privada Apenas Apara Leitura
        // em sequida cria uma lista contendo (username, password, email) na memoria dos usuarios
        // em seguida instancia a lista 
        private readonly List<(string Username, string Password, string Email)> _users = new();

        // Metodo para Registrar um Unico Usuario
        public void Register(string username, string password, string email)
        {
            _users.Add((username, password, email));
        }

        // Registra múltiplos usuários de uma vez usando `params` com tuplas
        // Exemplo de chamada:
        // service.RegisterMultiple(("u1","p1","e1@x"), ("u2","p2","e2@x"));
        public void RegisterMultiple(params (string Username, string Password, string Email)[] users)
        {
            foreach (var u in users)
            {
                _users.Add(u);
            }
        }

        // Autentica um usuário pelo par username/password
        public bool Authenticate(string username, string password)
        {
            foreach (var u in _users)
            {
                if (u.Username == username && u.Password == password) return true;
            }
            return false;
        }

        // Lista os usernames cadastrados (útil para debug/demonstração)
        public IEnumerable<string> ListUsernames()
        {
            foreach (var u in _users) yield return u.Username;
        }
    }
}
