﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOLUTIONS.GALAXY.Data.Repositories.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Scritps {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Scritps() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SOLUTIONS.GALAXY.Data.Repositories.Resources.Scritps", typeof(Scritps).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].[Jedi]
        ///   SET [Status] = @Status
        /// WHERE Id = {0}.
        /// </summary>
        public static string ChangeStatusJedi {
            get {
                return ResourceManager.GetString("ChangeStatusJedi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT OH.JediId, OH.HologramId FROM OrdersHolograms OH
        ///INNER JOIN Hologram H
        ///ON OH.HologramId = H.Id
        ///WHERE H.Status = 1
        ///AND H.Id = {0}.
        /// </summary>
        public static string GetOrderHolograms {
            get {
                return ResourceManager.GetString("GetOrderHolograms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT OH.JediId, OH.HologramId FROM OrdersHolograms OH
        ///INNER JOIN Hologram H
        ///ON OH.HologramId = H.Id
        ///AND OH.HologramId = {0}
        ///AND OH.JediId = {1}.
        /// </summary>
        public static string GetOrderHologramsByIds {
            get {
                return ResourceManager.GetString("GetOrderHologramsByIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Jedi([Name],Age,LightsaberColor,Grade,[Status]) Values (@Name, @Age, @LightsaberColor, @Grade,1);.
        /// </summary>
        public static string InsertJedi {
            get {
                return ResourceManager.GetString("InsertJedi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [dbo].[OrdersHolograms]
        ///           ([JediId]
        ///           ,[HologramId])
        ///     VALUES
        ///           (@JediId,@HologramId).
        /// </summary>
        public static string InsertOrder {
            get {
                return ResourceManager.GetString("InsertOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].[Jedi]
        ///   SET [Name] = @Name,
        ///       [Age] = @Age,
        ///       [LightsaberColor] = @LightsaberColor
        ///      ,[Grade] =@Grade
        /// WHERE Id = {0}.
        /// </summary>
        public static string UpdateJedi {
            get {
                return ResourceManager.GetString("UpdateJedi", resourceCulture);
            }
        }
    }
}