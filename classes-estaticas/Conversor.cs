namespace classes_estaticas
{
    public class Conversor
    {
        // propriedade estática
        public static float Temperatura { get; set; }
        // Método estático
        public static float CelsiusParaFahreheint(float celsius)
        {
            Temperatura = celsius;

            float fahreinheit = (Temperatura * 1.8f) + 32;

            return fahreinheit;
        }

        public static float FahreinheitParaCelsius(float fahreinheit)
        {
            Temperatura = fahreinheit;

            float celsius = (Temperatura - 32) / 1.8f;

            return celsius;
        }
    }
}