using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class TipoDocumentoMethods
    {
        private ManagerTipoDocumentoModel ADTipoDocumentosManager;

        public TipoDocumentoMethods()
        {
            ADTipoDocumentosManager = new ManagerTipoDocumentoModel();
        }
        public bool Crear(TipoDocumentoModel aTipoDocumento)
        {
            return ADTipoDocumentosManager.Insert(aTipoDocumento);
        }

        public bool Editar(TipoDocumentoModel aTipoDocumento)
        {
            return ADTipoDocumentosManager.Update(aTipoDocumento);
        }

        public bool Eliminar(int aID_TipoDocumento)
        {
            return ADTipoDocumentosManager.Delete(aID_TipoDocumento);
        }

        public TipoDocumentoModel ObtenerUno(int aID_TipoDocumento)
        {
            return ADTipoDocumentosManager.GetTipoDocumentoModel(aID_TipoDocumento);
        }

        public List<TipoDocumentoModel> ObtenerTodos()
        {
            return ADTipoDocumentosManager.TipoDocumentoModelSelectAll();
        }
    }
}
