﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControleNutricionalClient.ServiceGrupo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Grupo", Namespace="http://schemas.datacontract.org/2004/07/ControleNutricionalService.Models")]
    [System.SerializableAttribute()]
    public partial class Grupo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControleNutricionalClient.ServiceGrupo.Alimento[] AlimentosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControleNutricionalClient.ServiceGrupo.Alimento[] Alimentos {
            get {
                return this.AlimentosField;
            }
            set {
                if ((object.ReferenceEquals(this.AlimentosField, value) != true)) {
                    this.AlimentosField = value;
                    this.RaisePropertyChanged("Alimentos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alimento", Namespace="http://schemas.datacontract.org/2004/07/ControleNutricionalService.Models")]
    [System.SerializableAttribute()]
    public partial class Alimento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> AcucarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> CalcioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> ChoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> ColesterolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> FerroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Fibra_alimentarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> FosforoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Gordura_transField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Gorduras_saturadasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Gorduras_totaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GrupoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControleNutricionalClient.ServiceGrupo.Grupo Grupo1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> MagnesioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> MonoinsaturadosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PoliinsaturadosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PorcaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PotassioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> ProteinasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControleNutricionalClient.ServiceGrupo.Refeicao Refeicao1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> SelenioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> SodioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Valor_caloricoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_aField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_bField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_b1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_b12Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_b2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_b3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_b6Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_b9Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_cField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_dField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Vitamina_eField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> ZincoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Acucar {
            get {
                return this.AcucarField;
            }
            set {
                if ((this.AcucarField.Equals(value) != true)) {
                    this.AcucarField = value;
                    this.RaisePropertyChanged("Acucar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Calcio {
            get {
                return this.CalcioField;
            }
            set {
                if ((this.CalcioField.Equals(value) != true)) {
                    this.CalcioField = value;
                    this.RaisePropertyChanged("Calcio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Cho {
            get {
                return this.ChoField;
            }
            set {
                if ((this.ChoField.Equals(value) != true)) {
                    this.ChoField = value;
                    this.RaisePropertyChanged("Cho");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Colesterol {
            get {
                return this.ColesterolField;
            }
            set {
                if ((this.ColesterolField.Equals(value) != true)) {
                    this.ColesterolField = value;
                    this.RaisePropertyChanged("Colesterol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Ferro {
            get {
                return this.FerroField;
            }
            set {
                if ((this.FerroField.Equals(value) != true)) {
                    this.FerroField = value;
                    this.RaisePropertyChanged("Ferro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Fibra_alimentar {
            get {
                return this.Fibra_alimentarField;
            }
            set {
                if ((this.Fibra_alimentarField.Equals(value) != true)) {
                    this.Fibra_alimentarField = value;
                    this.RaisePropertyChanged("Fibra_alimentar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Fosforo {
            get {
                return this.FosforoField;
            }
            set {
                if ((this.FosforoField.Equals(value) != true)) {
                    this.FosforoField = value;
                    this.RaisePropertyChanged("Fosforo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Gordura_trans {
            get {
                return this.Gordura_transField;
            }
            set {
                if ((this.Gordura_transField.Equals(value) != true)) {
                    this.Gordura_transField = value;
                    this.RaisePropertyChanged("Gordura_trans");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Gorduras_saturadas {
            get {
                return this.Gorduras_saturadasField;
            }
            set {
                if ((this.Gorduras_saturadasField.Equals(value) != true)) {
                    this.Gorduras_saturadasField = value;
                    this.RaisePropertyChanged("Gorduras_saturadas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Gorduras_totais {
            get {
                return this.Gorduras_totaisField;
            }
            set {
                if ((this.Gorduras_totaisField.Equals(value) != true)) {
                    this.Gorduras_totaisField = value;
                    this.RaisePropertyChanged("Gorduras_totais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Grupo {
            get {
                return this.GrupoField;
            }
            set {
                if ((this.GrupoField.Equals(value) != true)) {
                    this.GrupoField = value;
                    this.RaisePropertyChanged("Grupo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControleNutricionalClient.ServiceGrupo.Grupo Grupo1 {
            get {
                return this.Grupo1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Grupo1Field, value) != true)) {
                    this.Grupo1Field = value;
                    this.RaisePropertyChanged("Grupo1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Magnesio {
            get {
                return this.MagnesioField;
            }
            set {
                if ((this.MagnesioField.Equals(value) != true)) {
                    this.MagnesioField = value;
                    this.RaisePropertyChanged("Magnesio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Monoinsaturados {
            get {
                return this.MonoinsaturadosField;
            }
            set {
                if ((this.MonoinsaturadosField.Equals(value) != true)) {
                    this.MonoinsaturadosField = value;
                    this.RaisePropertyChanged("Monoinsaturados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Poliinsaturados {
            get {
                return this.PoliinsaturadosField;
            }
            set {
                if ((this.PoliinsaturadosField.Equals(value) != true)) {
                    this.PoliinsaturadosField = value;
                    this.RaisePropertyChanged("Poliinsaturados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Porcao {
            get {
                return this.PorcaoField;
            }
            set {
                if ((this.PorcaoField.Equals(value) != true)) {
                    this.PorcaoField = value;
                    this.RaisePropertyChanged("Porcao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Potassio {
            get {
                return this.PotassioField;
            }
            set {
                if ((this.PotassioField.Equals(value) != true)) {
                    this.PotassioField = value;
                    this.RaisePropertyChanged("Potassio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Proteinas {
            get {
                return this.ProteinasField;
            }
            set {
                if ((this.ProteinasField.Equals(value) != true)) {
                    this.ProteinasField = value;
                    this.RaisePropertyChanged("Proteinas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControleNutricionalClient.ServiceGrupo.Refeicao Refeicao1 {
            get {
                return this.Refeicao1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Refeicao1Field, value) != true)) {
                    this.Refeicao1Field = value;
                    this.RaisePropertyChanged("Refeicao1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Selenio {
            get {
                return this.SelenioField;
            }
            set {
                if ((this.SelenioField.Equals(value) != true)) {
                    this.SelenioField = value;
                    this.RaisePropertyChanged("Selenio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Sodio {
            get {
                return this.SodioField;
            }
            set {
                if ((this.SodioField.Equals(value) != true)) {
                    this.SodioField = value;
                    this.RaisePropertyChanged("Sodio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Valor_calorico {
            get {
                return this.Valor_caloricoField;
            }
            set {
                if ((this.Valor_caloricoField.Equals(value) != true)) {
                    this.Valor_caloricoField = value;
                    this.RaisePropertyChanged("Valor_calorico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_a {
            get {
                return this.Vitamina_aField;
            }
            set {
                if ((this.Vitamina_aField.Equals(value) != true)) {
                    this.Vitamina_aField = value;
                    this.RaisePropertyChanged("Vitamina_a");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b {
            get {
                return this.Vitamina_bField;
            }
            set {
                if ((this.Vitamina_bField.Equals(value) != true)) {
                    this.Vitamina_bField = value;
                    this.RaisePropertyChanged("Vitamina_b");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b1 {
            get {
                return this.Vitamina_b1Field;
            }
            set {
                if ((this.Vitamina_b1Field.Equals(value) != true)) {
                    this.Vitamina_b1Field = value;
                    this.RaisePropertyChanged("Vitamina_b1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b12 {
            get {
                return this.Vitamina_b12Field;
            }
            set {
                if ((this.Vitamina_b12Field.Equals(value) != true)) {
                    this.Vitamina_b12Field = value;
                    this.RaisePropertyChanged("Vitamina_b12");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b2 {
            get {
                return this.Vitamina_b2Field;
            }
            set {
                if ((this.Vitamina_b2Field.Equals(value) != true)) {
                    this.Vitamina_b2Field = value;
                    this.RaisePropertyChanged("Vitamina_b2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b3 {
            get {
                return this.Vitamina_b3Field;
            }
            set {
                if ((this.Vitamina_b3Field.Equals(value) != true)) {
                    this.Vitamina_b3Field = value;
                    this.RaisePropertyChanged("Vitamina_b3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b6 {
            get {
                return this.Vitamina_b6Field;
            }
            set {
                if ((this.Vitamina_b6Field.Equals(value) != true)) {
                    this.Vitamina_b6Field = value;
                    this.RaisePropertyChanged("Vitamina_b6");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_b9 {
            get {
                return this.Vitamina_b9Field;
            }
            set {
                if ((this.Vitamina_b9Field.Equals(value) != true)) {
                    this.Vitamina_b9Field = value;
                    this.RaisePropertyChanged("Vitamina_b9");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_c {
            get {
                return this.Vitamina_cField;
            }
            set {
                if ((this.Vitamina_cField.Equals(value) != true)) {
                    this.Vitamina_cField = value;
                    this.RaisePropertyChanged("Vitamina_c");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_d {
            get {
                return this.Vitamina_dField;
            }
            set {
                if ((this.Vitamina_dField.Equals(value) != true)) {
                    this.Vitamina_dField = value;
                    this.RaisePropertyChanged("Vitamina_d");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Vitamina_e {
            get {
                return this.Vitamina_eField;
            }
            set {
                if ((this.Vitamina_eField.Equals(value) != true)) {
                    this.Vitamina_eField = value;
                    this.RaisePropertyChanged("Vitamina_e");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Zinco {
            get {
                return this.ZincoField;
            }
            set {
                if ((this.ZincoField.Equals(value) != true)) {
                    this.ZincoField = value;
                    this.RaisePropertyChanged("Zinco");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Refeicao", Namespace="http://schemas.datacontract.org/2004/07/ControleNutricionalService.Models")]
    [System.SerializableAttribute()]
    public partial class Refeicao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControleNutricionalClient.ServiceGrupo.Alimento[] AlimentosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControleNutricionalClient.ServiceGrupo.Alimento[] Alimentos {
            get {
                return this.AlimentosField;
            }
            set {
                if ((object.ReferenceEquals(this.AlimentosField, value) != true)) {
                    this.AlimentosField = value;
                    this.RaisePropertyChanged("Alimentos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceGrupo.ISeviceGrupo")]
    public interface ISeviceGrupo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeviceGrupo/findall", ReplyAction="http://tempuri.org/ISeviceGrupo/findallResponse")]
        ControleNutricionalClient.ServiceGrupo.Grupo[] findall();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeviceGrupo/findall", ReplyAction="http://tempuri.org/ISeviceGrupo/findallResponse")]
        System.Threading.Tasks.Task<ControleNutricionalClient.ServiceGrupo.Grupo[]> findallAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISeviceGrupoChannel : ControleNutricionalClient.ServiceGrupo.ISeviceGrupo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SeviceGrupoClient : System.ServiceModel.ClientBase<ControleNutricionalClient.ServiceGrupo.ISeviceGrupo>, ControleNutricionalClient.ServiceGrupo.ISeviceGrupo {
        
        public SeviceGrupoClient() {
        }
        
        public SeviceGrupoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SeviceGrupoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeviceGrupoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeviceGrupoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ControleNutricionalClient.ServiceGrupo.Grupo[] findall() {
            return base.Channel.findall();
        }
        
        public System.Threading.Tasks.Task<ControleNutricionalClient.ServiceGrupo.Grupo[]> findallAsync() {
            return base.Channel.findallAsync();
        }
    }
}