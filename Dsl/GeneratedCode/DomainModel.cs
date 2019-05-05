﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Company.MobileDSL
{
	/// <summary>
	/// DomainModel MobileDSLDomainModel
	/// Description for Company.MobileDSL.MobileDSL
	/// </summary>
	[DslDesign::DisplayNameResource("Company.MobileDSL.MobileDSLDomainModel.DisplayName", typeof(global::Company.MobileDSL.MobileDSLDomainModel), "Company.MobileDSL.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.MobileDSL.MobileDSLDomainModel.Description", typeof(global::Company.MobileDSL.MobileDSLDomainModel), "Company.MobileDSL.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("55af103f-91cc-4922-a2b2-90e589a6f5a2")]
	public partial class MobileDSLDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// MobileDSLDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x55af103f, 0x91cc, 0x4922, 0xa2, 0xb2, 0x90, 0xe5, 0x89, 0xa6, 0xf5, 0xa2);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public MobileDSLDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(NamedElement),
				typeof(ComponentModel),
				typeof(Controller),
				typeof(Port),
				typeof(InPort),
				typeof(OutPort),
				typeof(Comment),
				typeof(State_old2),
				typeof(State),
				typeof(ClassWithPorts),
				typeof(ShowForm),
				typeof(Event),
				typeof(Primitive),
				typeof(Connection),
				typeof(ComponentModelHasComments),
				typeof(ComponentModelHasControllers),
				typeof(CommentReferencesSubjects),
				typeof(ControllerHasStates2),
				typeof(State_old2ReferencesPreviousStates),
				typeof(ControllerHasStates),
				typeof(ClassWithPortsHasPorts),
				typeof(StateHasShowForms),
				typeof(ShowFormHasEvents),
				typeof(ShowFormHasPrimitives),
				typeof(MobileDSLDiagram),
				typeof(AssociationLink),
				typeof(CommentLink),
				typeof(StateConnector),
				typeof(ControllerShape),
				typeof(CommentBoxShape),
				typeof(StateShape),
				typeof(GeometryShape1),
				typeof(CompartmentShape1),
				typeof(InPortShape),
				typeof(OutPortShape),
				typeof(global::Company.MobileDSL.FixUpDiagram),
				typeof(global::Company.MobileDSL.DecoratorPropertyChanged),
				typeof(global::Company.MobileDSL.ConnectorRolePlayerChanged),
				typeof(global::Company.MobileDSL.CompartmentItemAddRule),
				typeof(global::Company.MobileDSL.CompartmentItemDeleteRule),
				typeof(global::Company.MobileDSL.CompartmentItemRolePlayerChangeRule),
				typeof(global::Company.MobileDSL.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::Company.MobileDSL.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(NamedElement), "Name", NamedElement.NameDomainPropertyId, typeof(NamedElement.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Controller), "Kind", Controller.KindDomainPropertyId, typeof(Controller.KindPropertyHandler)),
				new DomainMemberInfo(typeof(Controller), "isFirst", Controller.isFirstDomainPropertyId, typeof(Controller.isFirstPropertyHandler)),
				new DomainMemberInfo(typeof(Comment), "Text", Comment.TextDomainPropertyId, typeof(Comment.TextPropertyHandler)),
				new DomainMemberInfo(typeof(State_old2), "isFirstState", State_old2.isFirstStateDomainPropertyId, typeof(State_old2.isFirstStatePropertyHandler)),
				new DomainMemberInfo(typeof(Connection), "SourceRoleName", Connection.SourceRoleNameDomainPropertyId, typeof(Connection.SourceRoleNamePropertyHandler)),
				new DomainMemberInfo(typeof(Connection), "TargetRoleName", Connection.TargetRoleNameDomainPropertyId, typeof(Connection.TargetRoleNamePropertyHandler)),
				new DomainMemberInfo(typeof(State_old2ReferencesPreviousStates), "condition", State_old2ReferencesPreviousStates.conditionDomainPropertyId, typeof(State_old2ReferencesPreviousStates.conditionPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(Connection), "Source", Connection.SourceDomainRoleId),
				new DomainRolePlayerInfo(typeof(Connection), "Target", Connection.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(ComponentModelHasComments), "ComponentModel", ComponentModelHasComments.ComponentModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(ComponentModelHasComments), "Comment", ComponentModelHasComments.CommentDomainRoleId),
				new DomainRolePlayerInfo(typeof(ComponentModelHasControllers), "ComponentModel", ComponentModelHasControllers.ComponentModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(ComponentModelHasControllers), "Controller", ComponentModelHasControllers.ControllerDomainRoleId),
				new DomainRolePlayerInfo(typeof(CommentReferencesSubjects), "Comment", CommentReferencesSubjects.CommentDomainRoleId),
				new DomainRolePlayerInfo(typeof(CommentReferencesSubjects), "Subject", CommentReferencesSubjects.SubjectDomainRoleId),
				new DomainRolePlayerInfo(typeof(ControllerHasStates2), "Controller", ControllerHasStates2.ControllerDomainRoleId),
				new DomainRolePlayerInfo(typeof(ControllerHasStates2), "State_old2", ControllerHasStates2.State_old2DomainRoleId),
				new DomainRolePlayerInfo(typeof(State_old2ReferencesPreviousStates), "SourceState_old2", State_old2ReferencesPreviousStates.SourceState_old2DomainRoleId),
				new DomainRolePlayerInfo(typeof(State_old2ReferencesPreviousStates), "TargetState_old2", State_old2ReferencesPreviousStates.TargetState_old2DomainRoleId),
				new DomainRolePlayerInfo(typeof(ControllerHasStates), "Controller", ControllerHasStates.ControllerDomainRoleId),
				new DomainRolePlayerInfo(typeof(ControllerHasStates), "State", ControllerHasStates.StateDomainRoleId),
				new DomainRolePlayerInfo(typeof(ClassWithPortsHasPorts), "ClassWithPorts", ClassWithPortsHasPorts.ClassWithPortsDomainRoleId),
				new DomainRolePlayerInfo(typeof(ClassWithPortsHasPorts), "Port", ClassWithPortsHasPorts.PortDomainRoleId),
				new DomainRolePlayerInfo(typeof(StateHasShowForms), "State", StateHasShowForms.StateDomainRoleId),
				new DomainRolePlayerInfo(typeof(StateHasShowForms), "ShowForm", StateHasShowForms.ShowFormDomainRoleId),
				new DomainRolePlayerInfo(typeof(ShowFormHasEvents), "ShowForm", ShowFormHasEvents.ShowFormDomainRoleId),
				new DomainRolePlayerInfo(typeof(ShowFormHasEvents), "Event", ShowFormHasEvents.EventDomainRoleId),
				new DomainRolePlayerInfo(typeof(ShowFormHasPrimitives), "ShowForm", ShowFormHasPrimitives.ShowFormDomainRoleId),
				new DomainRolePlayerInfo(typeof(ShowFormHasPrimitives), "Primitive", ShowFormHasPrimitives.PrimitiveDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(24);
				createElementMap.Add(typeof(ComponentModel), 0);
				createElementMap.Add(typeof(Controller), 1);
				createElementMap.Add(typeof(InPort), 2);
				createElementMap.Add(typeof(OutPort), 3);
				createElementMap.Add(typeof(Comment), 4);
				createElementMap.Add(typeof(State_old2), 5);
				createElementMap.Add(typeof(State), 6);
				createElementMap.Add(typeof(ShowForm), 7);
				createElementMap.Add(typeof(Event), 8);
				createElementMap.Add(typeof(Primitive), 9);
				createElementMap.Add(typeof(MobileDSLDiagram), 10);
				createElementMap.Add(typeof(AssociationLink), 11);
				createElementMap.Add(typeof(CommentLink), 12);
				createElementMap.Add(typeof(StateConnector), 13);
				createElementMap.Add(typeof(ControllerShape), 14);
				createElementMap.Add(typeof(CommentBoxShape), 15);
				createElementMap.Add(typeof(StateShape), 16);
				createElementMap.Add(typeof(GeometryShape1), 17);
				createElementMap.Add(typeof(CompartmentShape1), 18);
				createElementMap.Add(typeof(InPortShape), 19);
				createElementMap.Add(typeof(OutPortShape), 20);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Company.MobileDSL.MobileDSLDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new ComponentModel(partition, propertyAssignments);
				case 1: return new Controller(partition, propertyAssignments);
				case 2: return new InPort(partition, propertyAssignments);
				case 3: return new OutPort(partition, propertyAssignments);
				case 4: return new Comment(partition, propertyAssignments);
				case 5: return new State_old2(partition, propertyAssignments);
				case 6: return new State(partition, propertyAssignments);
				case 7: return new ShowForm(partition, propertyAssignments);
				case 8: return new Event(partition, propertyAssignments);
				case 9: return new Primitive(partition, propertyAssignments);
				case 10: return new MobileDSLDiagram(partition, propertyAssignments);
				case 11: return new AssociationLink(partition, propertyAssignments);
				case 12: return new CommentLink(partition, propertyAssignments);
				case 13: return new StateConnector(partition, propertyAssignments);
				case 14: return new ControllerShape(partition, propertyAssignments);
				case 15: return new CommentBoxShape(partition, propertyAssignments);
				case 16: return new StateShape(partition, propertyAssignments);
				case 17: return new GeometryShape1(partition, propertyAssignments);
				case 18: return new CompartmentShape1(partition, propertyAssignments);
				case 19: return new InPortShape(partition, propertyAssignments);
				case 20: return new OutPortShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(11);
				createElementLinkMap.Add(typeof(Connection), 0);
				createElementLinkMap.Add(typeof(ComponentModelHasComments), 1);
				createElementLinkMap.Add(typeof(ComponentModelHasControllers), 2);
				createElementLinkMap.Add(typeof(CommentReferencesSubjects), 3);
				createElementLinkMap.Add(typeof(ControllerHasStates2), 4);
				createElementLinkMap.Add(typeof(State_old2ReferencesPreviousStates), 5);
				createElementLinkMap.Add(typeof(ControllerHasStates), 6);
				createElementLinkMap.Add(typeof(ClassWithPortsHasPorts), 7);
				createElementLinkMap.Add(typeof(StateHasShowForms), 8);
				createElementLinkMap.Add(typeof(ShowFormHasEvents), 9);
				createElementLinkMap.Add(typeof(ShowFormHasPrimitives), 10);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Company.MobileDSL.MobileDSLDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new Connection(partition, roleAssignments, propertyAssignments);
				case 1: return new ComponentModelHasComments(partition, roleAssignments, propertyAssignments);
				case 2: return new ComponentModelHasControllers(partition, roleAssignments, propertyAssignments);
				case 3: return new CommentReferencesSubjects(partition, roleAssignments, propertyAssignments);
				case 4: return new ControllerHasStates2(partition, roleAssignments, propertyAssignments);
				case 5: return new State_old2ReferencesPreviousStates(partition, roleAssignments, propertyAssignments);
				case 6: return new ControllerHasStates(partition, roleAssignments, propertyAssignments);
				case 7: return new ClassWithPortsHasPorts(partition, roleAssignments, propertyAssignments);
				case 8: return new StateHasShowForms(partition, roleAssignments, propertyAssignments);
				case 9: return new ShowFormHasEvents(partition, roleAssignments, propertyAssignments);
				case 10: return new ShowFormHasPrimitives(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Company.MobileDSL.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return MobileDSLDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (MobileDSLDomainModel.resourceManager == null)
				{
					MobileDSLDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(MobileDSLDomainModel).Assembly);
				}
				return MobileDSLDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return MobileDSLDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return MobileDSLDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (MobileDSLDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new MobileDSLCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					MobileDSLDomainModel.copyClosure = copyFilter;
				}
				return MobileDSLDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (MobileDSLDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new MobileDSLDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					MobileDSLDomainModel.removeClosure = removeFilter;
				}
				return MobileDSLDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.DecoratorPropertyChanged));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::Company.MobileDSL.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.DecoratorPropertyChanged));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::Company.MobileDSL.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MobileDSLDeleteClosure : MobileDSLDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MobileDSLDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MobileDSLDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public MobileDSLDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Company.MobileDSL.ComponentModelHasComments.CommentDomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.ComponentModelHasControllers.ControllerDomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.ControllerHasStates2.State_old2DomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.ControllerHasStates.StateDomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.ClassWithPortsHasPorts.PortDomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.StateHasShowForms.ShowFormDomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.ShowFormHasEvents.EventDomainRoleId, true);
			DomainRoles.Add(global::Company.MobileDSL.ShowFormHasPrimitives.PrimitiveDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MobileDSLCopyClosure : MobileDSLCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MobileDSLCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MobileDSLCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MobileDSLCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}

