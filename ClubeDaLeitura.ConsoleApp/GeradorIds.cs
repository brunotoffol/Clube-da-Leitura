namespace ClubeDaLeitura.ConsoleApp
{
    public static class GeradorIds
    {
        public static int IdAmigos = 0;

        public static int GerarIdAmigo()
        {
            IdAmigos++;

            return IdAmigos;
        }


    }
}
