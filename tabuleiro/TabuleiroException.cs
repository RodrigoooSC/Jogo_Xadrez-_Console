using System;

namespace tabuleiro
{
    class TabuleiroException : Exception // Exceção personalizada
    {
        public TabuleiroException(string msg): base(msg)
        {
        }
    }
}
