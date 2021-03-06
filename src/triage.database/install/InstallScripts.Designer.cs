﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace triage.database.install {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class InstallScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InstallScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("triage.database.install.InstallScripts", typeof(InstallScripts).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[Module_Insert]
        ///    @name nvarchar(256)
        ///AS
        ///BEGIN
        ///BEGIN TRANSACTION
        ///    DECLARE @MID as int 
        ///    SELECT @MID = [M].[Id]
        ///    FROM [Modules] AS [M] 
        ///    WHERE [M].[Name] = @name 
        ///
        ///    IF @MID IS NULL -- if the module doesn&apos;t exist create it
        ///    BEGIN
        ///        INSERT INTO Modules([Name]) 
        ///        VALUES ( @name )
        ///        SELECT @MID = SCOPE_IDENTITY()
        ///    END
        ///COMMIT TRANSACTION
        ///SELECT @MID, @name
        ///END.
        /// </summary>
        internal static string Create_Module_Insert {
            get {
                return ResourceManager.GetString("Create_Module_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[Routine_Insert]
        ///    @name nvarchar(256)
        ///AS
        ///BEGIN
        ///BEGIN TRANSACTION
        ///    DECLARE @RID as int
        ///    SELECT @RID = [R].[Id]
        ///    FROM [Routine] AS [R] 
        ///    WHERE [R].[Name] = @name 
        ///
        ///    IF @RID IS NULL -- if the method wasn&apos;t found create it
        ///    BEGIN
        ///        INSERT INTO Routine([Name]) 
        ///        VALUES ( @name )
        ///        SELECT @RID = SCOPE_IDENTITY()
        ///    END
        ///COMMIT TRANSACTION
        ///SELECT @RID, @name
        ///END.
        /// </summary>
        internal static string Create_Routine_Insert {
            get {
                return ResourceManager.GetString("Create_Routine_Insert", resourceCulture);
            }
        }
    }
}
