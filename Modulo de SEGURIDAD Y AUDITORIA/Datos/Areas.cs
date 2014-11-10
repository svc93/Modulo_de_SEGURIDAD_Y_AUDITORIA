using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class Areas
    { 
        public Dataset.SISTEMADataSet.Cat_AreasDataTable tCatAreas()
        {
            Dataset.SISTEMADataSetTableAdapters.Cat_AreasTableAdapter daCarAreas = new Dataset.SISTEMADataSetTableAdapters.Cat_AreasTableAdapter();
            Dataset.SISTEMADataSet.Cat_AreasDataTable dtCatAreas = new Datos.Dataset.SISTEMADataSet.Cat_AreasDataTable();
            daCarAreas.Fill(dtCatAreas);
            return dtCatAreas;
        }

    }
}
