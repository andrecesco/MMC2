//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMC2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_relatorio_projeto
    {
        public int projeto_id { get; set; }
        public string projeto { get; set; }
        public string Cnpj { get; set; }
        public string cliente { get; set; }
        public string DescricaoProjeto { get; set; }
        public System.DateTime DtIniProjeto { get; set; }
        public System.DateTime DtFimProjeto { get; set; }
        public decimal valor { get; set; }
        public Nullable<int> tarefa_id { get; set; }
        public string tarefa { get; set; }
        public string DescricaoTarefa { get; set; }
        public string colaborador { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> DtIniTarefa { get; set; }
        public Nullable<System.DateTime> DtFimTarefa { get; set; }
        public Nullable<double> tempoestimado { get; set; }
        public string prioridade { get; set; }
        public Nullable<int> historico_id { get; set; }
        public Nullable<System.DateTime> datalancamento { get; set; }
        public Nullable<double> qtdhoras { get; set; }
        public string DescricaoHistorico { get; set; }
    }
}
