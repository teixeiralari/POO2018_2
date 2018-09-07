using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    public class Tempo
    {
        private int hora, min, seg;

        public Tempo()
        {
            hora = min = seg = 0;
        }

        public Tempo(int hora, int min, int seg)
        {
            this.hora = hora;
            this.min = min;
            this.seg = seg;
        }

        public int getHora()
        {
            return hora;
        }

        public int getMin()
        {
            return min;
        }

        public int getSeg()
        {
            return seg;
        }

        public void setHora(int hora)
        {
            this.hora = hora;
        }

        public void setMin(int min)
        {
            this.min = min;
        }

        public void setSeg(int seg)
        {
            this.seg = seg;
        }

        public void solicitaTempo()
        {
            Console.Write("Insira a hora no formato hh mm ss: ");
            //Console.Write("Insira a hora: ");
            hora = int.Parse(Console.ReadLine());
            //Console.Write("Insira os minutos: ");
            min = int.Parse(Console.ReadLine());
           // Console.Write("Insira os segundos: ");
            seg = int.Parse(Console.ReadLine());
        }

        public void imprimeTempo()
        {
            if (hora < 10)
                Console.Write("0" + hora.ToString());// + ':' + min.ToString() + ':' + seg.ToString());
            else
                Console.Write(hora.ToString());
            if (min < 10)
                Console.Write(":0" + min.ToString());
            else
                Console.Write(":" + min.ToString());
            if (seg < 10)
                Console.Write(":0" + seg.ToString());
            else
                Console.Write(":" + seg.ToString());
            Console.WriteLine();

        }

        public Tempo adicionaTempo(Tempo t)
        {
            int segundos = convertSegundos() + t.convertSegundos();
            return convertHHMMSS(segundos);
        }

        public Tempo subtraiTempo(Tempo t)
        {
            int segundos = convertSegundos() - t.convertSegundos();
            return convertHHMMSS(segundos);
        }

        public int convertSegundos()
        {
            return hora * 3600 + min * 60 + seg;
        }

        public Tempo convertHHMMSS(int seg)
        {
            int h, m, s;

            h = seg / 3600;
            m = (seg - h * 3600)/60;
            s = seg - h * 3600 - m * 60;

            Tempo t = new Tempo(h, m, s);
            return t;
        }
    }
}
