using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VectorLuis
{
    public class Vector
    {
        private Punto _puntoOrigen;
        private Punto _puntoFinal;
        private double _magnitud;
        public Vector()
        {

        }
        public Vector(Punto origen, Punto Final)
        {
            _puntoOrigen = origen;
            _puntoFinal = Final;
            _magnitud = CalcularMagnitud();

        }

        public double CalcularMagnitud()
        {

            double primerTermino = Math.Pow(_puntoFinal.X - _puntoOrigen.X, 2);
            double segundoTermino = Math.Pow(_puntoFinal.Y - _puntoOrigen.Y, 2);


            return Math.Sqrt(primerTermino + segundoTermino);
        }

        public Punto PuntoOrigen
        {
            set
            {
                _puntoOrigen = value;
                _magnitud = CalcularMagnitud();

            }

            get
            {
                return _puntoOrigen;
            }
        }
        public Punto PuntoFinal
        {
            set
            {
                _puntoFinal = value;
                _magnitud = CalcularMagnitud();
            }

            get
            {
                return _puntoFinal;
            }
        }
        public double Magnitud
        {
            get
            {
                return _magnitud;
            }
        }
        public static Vector operator +(Vector primerVector, Vector segundoVector)
        {
            float nuevoOrigenX = primerVector.PuntoOrigen.X + segundoVector.PuntoOrigen.X;
            float nuevoOrigenY = primerVector.PuntoOrigen.Y + segundoVector.PuntoOrigen.Y;

            float nuevoFinalX = primerVector.PuntoFinal.X + segundoVector.PuntoFinal.X;
            float nuevoFinalY = primerVector.PuntoFinal.Y + segundoVector.PuntoFinal.Y;

            Punto nuevoOrigen = new Punto(nuevoOrigenX, nuevoOrigenY);
            Punto nuevoFinal = new Punto(nuevoFinalX, nuevoFinalY);

            return new Vector(nuevoOrigen, nuevoFinal);
        }
        public static Vector operator -(Vector primerVector, Vector segundoVector)
        {
            float nuevoOrigenX = primerVector.PuntoOrigen.X - segundoVector.PuntoOrigen.X;
            float nuevoOrigenY = primerVector.PuntoOrigen.Y - segundoVector.PuntoOrigen.Y;

            float nuevoFinalX = primerVector.PuntoFinal.X - segundoVector.PuntoFinal.X;
            float nuevoFinalY = primerVector.PuntoFinal.Y - segundoVector.PuntoFinal.Y;

            Punto nuevoOrigen = new Punto(nuevoOrigenX, nuevoOrigenY);
            Punto nuevoFinal = new Punto(nuevoFinalX, nuevoFinalY);

            return new Vector(nuevoOrigen, nuevoFinal);
        }
        public static Vector operator *(Vector primerVector, float escalar)
        {
            float nuevoOrigenX = primerVector.PuntoOrigen.X * escalar;
            float nuevoOrigenY = primerVector.PuntoOrigen.Y * escalar;

            float nuevoFinalX = primerVector.PuntoFinal.X * escalar;
            float nuevoFinalY = primerVector.PuntoFinal.Y * escalar;

            Punto nuevoOrigen = new Punto(nuevoOrigenX, escalar);
            Punto nuevoFinal = new Punto(nuevoFinalX, escalar);

            return new Vector(nuevoOrigen, nuevoFinal);
        }
        public static double operator *(Vector primerVector, Vector segundoVector)
        {
            double restaPuntosVec1X = primerVector.PuntoFinal.X - primerVector.PuntoOrigen.X;
            double restaPuntosVec1Y = primerVector.PuntoFinal.Y - primerVector.PuntoOrigen.Y;

            double restaPuntosVec2X = segundoVector.PuntoFinal.X - segundoVector.PuntoOrigen.X;
            double restaPuntosVec2Y = segundoVector.PuntoFinal.Y - segundoVector.PuntoOrigen.Y;

            return (restaPuntosVec1X * restaPuntosVec2X) + (restaPuntosVec1Y * restaPuntosVec2Y);
        }
    }
}
