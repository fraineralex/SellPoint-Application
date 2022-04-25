using System;

namespace Layers.Framework.ADO.Net
{
    public class clsBeTiposEntidades : ICloneable
    {
        private int mIdTipoEntidad = 0;
        private string mDescripcion = "";
        private int mIdGrupoEntidad = 0;
        private string mComentario = "";
        private string mStatus = "";
        private bool mNoEliminable = false;
        private DateTime mFechaRegistro = DateTime.Now;

        public int IdTipoEntidad
        {
            get
            {
                return mIdTipoEntidad;
            }
            set
            {
                mIdTipoEntidad = value;
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

        public clsBeTiposEntidades()
        {
        }

        public clsBeTiposEntidades
            (
                ref int IdTipoEntidad, string Descripcion, int IdGrupoEntidad, string Comentario, string Status, 
                bool NoEliminable, DateTime FechaRegistro
            )
        {
    		mIdTipoEntidad = IdTipoEntidad;
            mDescripcion = Descripcion;
            mIdGrupoEntidad = IdGrupoEntidad;
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
