﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.6.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Detailed information about conditions, problems or diagnoses
    /// </summary>
    [FhirType("Condition", IsResource=true)]
    [DataContract]
    public partial class Condition : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Condition; } }
        [NotMapped]
        public override string TypeName { get { return "Condition"; } }
        
        /// <summary>
        /// Preferred value set for Condition Clinical Status.
        /// (url: http://hl7.org/fhir/ValueSet/condition-clinical)
        /// </summary>
        [FhirEnumeration("ConditionClinicalStatusCodes")]
        public enum ConditionClinicalStatusCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("active"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("relapse"), Description("Relapse")]
            Relapse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("remission"), Description("Remission")]
            Remission,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("resolved"), Description("Resolved")]
            Resolved,
        }

        /// <summary>
        /// The verification status to support or decline the clinical status of the condition or diagnosis.
        /// (url: http://hl7.org/fhir/ValueSet/condition-ver-status)
        /// </summary>
        [FhirEnumeration("ConditionVerificationStatus")]
        public enum ConditionVerificationStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("provisional"), Description("Provisional")]
            Provisional,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("differential"), Description("Differential")]
            Differential,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("confirmed"), Description("Confirmed")]
            Confirmed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("refuted"), Description("Refuted")]
            Refuted,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("entered-in-error"), Description("Entered In Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("unknown"), Description("Unknown")]
            Unknown,
        }

        [FhirType("StageComponent")]
        [DataContract]
        public partial class StageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StageComponent"; } }
            
            /// <summary>
            /// Simple summary (disease specific)
            /// </summary>
            [FhirElement("summary", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Summary
            {
                get { return _Summary; }
                set { _Summary = value; OnPropertyChanged("Summary"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Summary;
            
            /// <summary>
            /// Formal record of assessment
            /// </summary>
            [FhirElement("assessment", InSummary=true, Order=50)]
            [References("ClinicalImpression","DiagnosticReport","Observation")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Assessment
            {
                get { if(_Assessment==null) _Assessment = new List<Hl7.Fhir.Model.ResourceReference>(); return _Assessment; }
                set { _Assessment = value; OnPropertyChanged("Assessment"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Assessment;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StageComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Summary != null) dest.Summary = (Hl7.Fhir.Model.CodeableConcept)Summary.DeepCopy();
                    if(Assessment != null) dest.Assessment = new List<Hl7.Fhir.Model.ResourceReference>(Assessment.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new StageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StageComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Summary, otherT.Summary)) return false;
                if( !DeepComparable.Matches(Assessment, otherT.Assessment)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StageComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Summary, otherT.Summary)) return false;
                if( !DeepComparable.IsExactly(Assessment, otherT.Assessment)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("EvidenceComponent")]
        [DataContract]
        public partial class EvidenceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "EvidenceComponent"; } }
            
            /// <summary>
            /// Manifestation/symptom
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Supporting information found elsewhere
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=50)]
            [References()]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Detail
            {
                get { if(_Detail==null) _Detail = new List<Hl7.Fhir.Model.ResourceReference>(); return _Detail; }
                set { _Detail = value; OnPropertyChanged("Detail"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Detail;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EvidenceComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(Detail != null) dest.Detail = new List<Hl7.Fhir.Model.ResourceReference>(Detail.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new EvidenceComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EvidenceComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EvidenceComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// External Ids for this condition
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// active | relapse | remission | resolved
        /// </summary>
        [FhirElement("clinicalStatus", InSummary=true, Order=100)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Condition.ConditionClinicalStatusCodes> ClinicalStatusElement
        {
            get { return _ClinicalStatusElement; }
            set { _ClinicalStatusElement = value; OnPropertyChanged("ClinicalStatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Condition.ConditionClinicalStatusCodes> _ClinicalStatusElement;
        
        /// <summary>
        /// active | relapse | remission | resolved
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Condition.ConditionClinicalStatusCodes? ClinicalStatus
        {
            get { return ClinicalStatusElement != null ? ClinicalStatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  ClinicalStatusElement = null; 
                else
                  ClinicalStatusElement = new Code<Hl7.Fhir.Model.Condition.ConditionClinicalStatusCodes>(value);
                OnPropertyChanged("ClinicalStatus");
            }
        }
        
        /// <summary>
        /// provisional | differential | confirmed | refuted | entered-in-error | unknown
        /// </summary>
        [FhirElement("verificationStatus", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Condition.ConditionVerificationStatus> VerificationStatusElement
        {
            get { return _VerificationStatusElement; }
            set { _VerificationStatusElement = value; OnPropertyChanged("VerificationStatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Condition.ConditionVerificationStatus> _VerificationStatusElement;
        
        /// <summary>
        /// provisional | differential | confirmed | refuted | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Condition.ConditionVerificationStatus? VerificationStatus
        {
            get { return VerificationStatusElement != null ? VerificationStatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  VerificationStatusElement = null; 
                else
                  VerificationStatusElement = new Code<Hl7.Fhir.Model.Condition.ConditionVerificationStatus>(value);
                OnPropertyChanged("VerificationStatus");
            }
        }
        
        /// <summary>
        /// complaint | symptom | finding | diagnosis
        /// </summary>
        [FhirElement("category", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Category
        {
            get { return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Category;
        
        /// <summary>
        /// Subjective severity of condition
        /// </summary>
        [FhirElement("severity", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Severity
        {
            get { return _Severity; }
            set { _Severity = value; OnPropertyChanged("Severity"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Severity;
        
        /// <summary>
        /// Identification of the condition, problem or diagnosis
        /// </summary>
        [FhirElement("code", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Code;
        
        /// <summary>
        /// Anatomical location, if relevant
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> BodySite
        {
            get { if(_BodySite==null) _BodySite = new List<Hl7.Fhir.Model.CodeableConcept>(); return _BodySite; }
            set { _BodySite = value; OnPropertyChanged("BodySite"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _BodySite;
        
        /// <summary>
        /// Who has the condition?
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=160)]
        [References("Patient","Group")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// Encounter when condition first asserted
        /// </summary>
        [FhirElement("context", InSummary=true, Order=170)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Context
        {
            get { return _Context; }
            set { _Context = value; OnPropertyChanged("Context"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Context;
        
        /// <summary>
        /// Estimated or actual date,  date-time, or age
        /// </summary>
        [FhirElement("onset", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Age),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.FhirString))]
        [DataMember]
        public Hl7.Fhir.Model.Element Onset
        {
            get { return _Onset; }
            set { _Onset = value; OnPropertyChanged("Onset"); }
        }
        
        private Hl7.Fhir.Model.Element _Onset;
        
        /// <summary>
        /// If/when in resolution/remission
        /// </summary>
        [FhirElement("abatement", InSummary=true, Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Age),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.FhirString))]
        [DataMember]
        public Hl7.Fhir.Model.Element Abatement
        {
            get { return _Abatement; }
            set { _Abatement = value; OnPropertyChanged("Abatement"); }
        }
        
        private Hl7.Fhir.Model.Element _Abatement;
        
        /// <summary>
        /// When first entered
        /// </summary>
        [FhirElement("dateRecorded", InSummary=true, Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.Date DateRecordedElement
        {
            get { return _DateRecordedElement; }
            set { _DateRecordedElement = value; OnPropertyChanged("DateRecordedElement"); }
        }
        
        private Hl7.Fhir.Model.Date _DateRecordedElement;
        
        /// <summary>
        /// When first entered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateRecorded
        {
            get { return DateRecordedElement != null ? DateRecordedElement.Value : null; }
            set
            {
                if (value == null)
                  DateRecordedElement = null; 
                else
                  DateRecordedElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("DateRecorded");
            }
        }
        
        /// <summary>
        /// Person who asserts this condition
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=210)]
        [References("Practitioner","Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Asserter
        {
            get { return _Asserter; }
            set { _Asserter = value; OnPropertyChanged("Asserter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Asserter;
        
        /// <summary>
        /// Stage/grade, usually assessed formally
        /// </summary>
        [FhirElement("stage", InSummary=true, Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.Condition.StageComponent Stage
        {
            get { return _Stage; }
            set { _Stage = value; OnPropertyChanged("Stage"); }
        }
        
        private Hl7.Fhir.Model.Condition.StageComponent _Stage;
        
        /// <summary>
        /// Supporting evidence
        /// </summary>
        [FhirElement("evidence", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Condition.EvidenceComponent> Evidence
        {
            get { if(_Evidence==null) _Evidence = new List<Hl7.Fhir.Model.Condition.EvidenceComponent>(); return _Evidence; }
            set { _Evidence = value; OnPropertyChanged("Evidence"); }
        }
        
        private List<Hl7.Fhir.Model.Condition.EvidenceComponent> _Evidence;
        
        /// <summary>
        /// Additional information about the Condition
        /// </summary>
        [FhirElement("note", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.Annotation> _Note;
        

        public static ElementDefinition.ConstraintComponent Condition_CON_1 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "stage.all(summary.exists() or assessment.exists())",
            Key = "con-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Stage SHALL have summary or assessment",
            Xpath = "exists(f:summary) or exists(f:assessment)"
        };

        public static ElementDefinition.ConstraintComponent Condition_CON_2 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "evidence.all(code.exists() or detail.exists())",
            Key = "con-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "evidence SHALL have code or details",
            Xpath = "exists(f:code) or exists(f:detail)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Condition_CON_1);
            InvariantConstraints.Add(Condition_CON_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Condition;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(ClinicalStatusElement != null) dest.ClinicalStatusElement = (Code<Hl7.Fhir.Model.Condition.ConditionClinicalStatusCodes>)ClinicalStatusElement.DeepCopy();
                if(VerificationStatusElement != null) dest.VerificationStatusElement = (Code<Hl7.Fhir.Model.Condition.ConditionVerificationStatus>)VerificationStatusElement.DeepCopy();
                if(Category != null) dest.Category = (Hl7.Fhir.Model.CodeableConcept)Category.DeepCopy();
                if(Severity != null) dest.Severity = (Hl7.Fhir.Model.CodeableConcept)Severity.DeepCopy();
                if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                if(BodySite != null) dest.BodySite = new List<Hl7.Fhir.Model.CodeableConcept>(BodySite.DeepCopy());
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(Context != null) dest.Context = (Hl7.Fhir.Model.ResourceReference)Context.DeepCopy();
                if(Onset != null) dest.Onset = (Hl7.Fhir.Model.Element)Onset.DeepCopy();
                if(Abatement != null) dest.Abatement = (Hl7.Fhir.Model.Element)Abatement.DeepCopy();
                if(DateRecordedElement != null) dest.DateRecordedElement = (Hl7.Fhir.Model.Date)DateRecordedElement.DeepCopy();
                if(Asserter != null) dest.Asserter = (Hl7.Fhir.Model.ResourceReference)Asserter.DeepCopy();
                if(Stage != null) dest.Stage = (Hl7.Fhir.Model.Condition.StageComponent)Stage.DeepCopy();
                if(Evidence != null) dest.Evidence = new List<Hl7.Fhir.Model.Condition.EvidenceComponent>(Evidence.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Condition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Condition;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if( !DeepComparable.Matches(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(Severity, otherT.Severity)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if( !DeepComparable.Matches(Onset, otherT.Onset)) return false;
            if( !DeepComparable.Matches(Abatement, otherT.Abatement)) return false;
            if( !DeepComparable.Matches(DateRecordedElement, otherT.DateRecordedElement)) return false;
            if( !DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if( !DeepComparable.Matches(Stage, otherT.Stage)) return false;
            if( !DeepComparable.Matches(Evidence, otherT.Evidence)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Condition;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if( !DeepComparable.IsExactly(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if( !DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
            if( !DeepComparable.IsExactly(Abatement, otherT.Abatement)) return false;
            if( !DeepComparable.IsExactly(DateRecordedElement, otherT.DateRecordedElement)) return false;
            if( !DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if( !DeepComparable.IsExactly(Stage, otherT.Stage)) return false;
            if( !DeepComparable.IsExactly(Evidence, otherT.Evidence)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            
            return true;
        }
        
    }
    
}
