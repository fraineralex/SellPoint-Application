using System;

namespace Layers.Framework.ADO.Net
{
    public class clsBeGruposEntidades : ICloneable
    {
        private int mIdGrupoEntidad = 0;
        private string mDescripcion = "";
        private string mComentario = "";
        private string mStatus = "";
        private bool mNoEliminable = false;
        private DateTime mFechaRegistro = DateTime.Now;

        public int IdGrupoEntidad
        {
            get
            {
                return mIdGrupoEntidad;
            }
            set
            {
                mIdGrupoEntidad = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return mDescripcion;
            }
            set
            {
                mDescripcion = value;
            }
        }

        public string Comentario
        {
            get
            {
                return mComentario;
            }
            set
            {
                mComentario = value;
            }
        }

        public string Status
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }

        public bool NoEliminable
        {
            get
            {
                return mNoEliminable;
            }
            set
            {
                mNoEliminable = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                return mFechaRegistro;
            }
            set
            {
                mFechaRegistro = value;
            }
        }

        public clsBeGruposEntidades()
        {
        }

        public clsBeGruposEntidades
            (
                ref int IdGrupoEntidad, string Descripcion, string Comentario, string Status, bool NoEliminable, 
                DateTime FechaRegistro
            )
        {
		    mIdGrupoEntidad = IdGrupoEntidad;
            mDescripcion = Descripcion;
            mComentario = Comentario;
            mStatus = Status;
            mNoEliminable = NoEliminable;
            mFechaRegistro = FechaRegistro;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
