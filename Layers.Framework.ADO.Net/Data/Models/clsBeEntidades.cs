using System;

namespace Layers.Framework.ADO.Net
{
    public class clsBeEntidades : ICloneable
    {
        private int mIdEntidad = 0;
        private string mDescripcion = "";
        private string mDireccion = "";
        private string mLocalidad = "";
        private string mTipoEntidad = "";
        private string mTipoDocumento = "";
        private double mNumeroDocumento = 0.0;
        private string mTelefono = "";
        private string mURLPaginaWeb = "";
        private string mURLFacebook = "";
        private string mURLInstagram = "";
        private string mURLTwitter = "";
        private string mURLTiktok = "";
        private int mIdGrupoEntidad = 0;
        private int mIdTipoEntidad = 0;
        private double mLimiteCredito = 0.0;
        private string mUserNameEntidad = "";
        private string mPasswordEntidad = "";
        private string mRolUserEntidad = "";
        private string mComentario = "";
        private string mStatus = "";
        private bool mNoEliminable = false;
        private DateTime mFechaRegistro = DateTime.Now;

        public int IdEntidad
        {
            get
            {
                return mIdEntidad;
            }
            set
            {
                mIdEntidad = value;
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

        public string Direccion
        {
            get
            {
                return mDireccion;
            }
            set
            {
                mDireccion = value;
            }
        }

        public string Localidad
        {
            get
            {
                return mLocalidad;
            }
            set
            {
                mLocalidad = value;
            }
        }

        public string TipoEntidad
        {
            get
            {
                return mTipoEntidad;
            }
            set
            {
                mTipoEntidad = value;
            }
        }

        public string TipoDocumento
        {
            get
            {
                return mTipoDocumento;
            }
            set
            {
                mTipoDocumento = value;
            }
        }

        public double NumeroDocumento
        {
            get
            {
                return mNumeroDocumento;
            }
            set
            {
                mNumeroDocumento = value;
            }
        }

        public string Telefono
        {
            get
            {
                return mTelefono;
            }
            set
            {
                mTelefono = value;
            }
        }

        public string URLPaginaWeb
        {
            get
            {
                return mURLPaginaWeb;
            }
            set
            {
                mURLPaginaWeb = value;
            }
        }

        public string URLFacebook
        {
            get
            {
                return mURLFacebook;
            }
            set
            {
                mURLFacebook = value;
            }
        }

        public string URLInstagram
        {
            get
            {
                return mURLInstagram;
            }
            set
            {
                mURLInstagram = value;
            }
        }

        public string URLTwitter
        {
            get
            {
                return mURLTwitter;
            }
            set
            {
                mURLTwitter = value;
            }
        }

        public string URLTiktok
        {
            get
            {
                return mURLTiktok;
            }
            set
            {
                mURLTiktok = value;
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

        public double LimiteCredito
        {
            get
            {
                return mLimiteCredito;
            }
            set
            {
                mLimiteCredito = value;
            }
        }

        public string UserNameEntidad
        {
            get
            {
                return mUserNameEntidad;
            }
            set
            {
                mUserNameEntidad = value;
            }
        }

        public string PasswordEntidad
        {
            get
            {
                return mPasswordEntidad;
            }
            set
            {
                mPasswordEntidad = value;
            }
        }

        public string RolUserEntidad
        {
            get
            {
                return mRolUserEntidad;
            }
            set
            {
                mRolUserEntidad = value;
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

        public clsBeEntidades()
        {
        }

        public clsBeEntidades
            (
                ref int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, 
                string TipoDocumento, double NumeroDocumento, string Telefono, string URLPaginaWeb, 
                string URLFacebook, string URLInstagram, string URLTwitter, string URLTiktok, int IdGrupoEntidad, 
                int IdTipoEntidad, double LimiteCredito, string UserNameEntidad, string PasswordEntidad, 
                string RolUserEntidad, string Comentario, string Status, bool NoEliminable, DateTime FechaRegistro
            )
        {
    		mIdEntidad = IdEntidad;
            mDescripcion = Descripcion;
            mDireccion = Direccion;
            mLocalidad = Localidad;
            mTipoEntidad = TipoEntidad;
            mTipoDocumento = TipoDocumento;
            mNumeroDocumento = NumeroDocumento;
            mTelefono = Telefono;
            mURLPaginaWeb = URLPaginaWeb;
            mURLFacebook = URLFacebook;
            mURLInstagram = URLInstagram;
            mURLTwitter = URLTwitter;
            mURLTiktok = URLTiktok;
            mIdGrupoEntidad = IdGrupoEntidad;
            mIdTipoEntidad = IdTipoEntidad;
            mLimiteCredito = LimiteCredito;
            mUserNameEntidad = UserNameEntidad;
            mPasswordEntidad = PasswordEntidad;
            mRolUserEntidad = RolUserEntidad;
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