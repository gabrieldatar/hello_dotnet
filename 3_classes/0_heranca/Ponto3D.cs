namespace _3_classes._0_heranca
{
    public class Ponto3D:Ponto
    {
        public int z;

        public Ponto3D(int x,int y,int z):base(x,y)
        {
            this.z=z;
            CalcularDistancia1();
        }

        public static void Caucular()
        {

        }

        public override void CalcularDistancia3()
        {
            
        }
    }
}