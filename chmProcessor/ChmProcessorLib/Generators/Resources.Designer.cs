﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4927
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChmProcessorLib.Generators {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso con establecimiento inflexible de tipos, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o vuelva a generar su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ChmProcessorLib.Generators.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso con establecimiento inflexible de tipos.
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
        ///   Busca una cadena traducida similar a &lt;form name=&quot;searchform&quot; method=&quot;post&quot; action=&quot;search.aspx&quot; id=&quot;searchform&quot; onsubmit=&quot;doFullTextSearch();return false;&quot;&gt;
        ///    &lt;p&gt;
        ///        &lt;img src=&quot;system-search.png&quot; align=&quot;middle&quot; alt=&quot;Search image&quot; /&gt;
        ///        &lt;b&gt;%Search Text%:&lt;/b&gt;&lt;br /&gt;
        ///        &lt;input type=&quot;text&quot; id=&quot;searchText&quot; style=&quot;width: 80%;&quot; name=&quot;searchText&quot; /&gt;
        ///        &lt;input type=&quot;button&quot; value=&quot;%Search%&quot; onclick=&quot;doFullTextSearch();&quot; id=&quot;Button1&quot;
        ///            name=&quot;Button1&quot; /&gt;
        ///    &lt;/p&gt;
        ///&lt;/form&gt;
        ///.
        /// </summary>
        internal static string SearchFormFullText {
            get {
                return ResourceManager.GetString("SearchFormFullText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &lt;form name=&quot;searchform&quot; method=&quot;post&quot; action=&quot;search.aspx&quot; id=&quot;searchform&quot; onsubmit=&quot;doSearch();return false;&quot;&gt;
        ///    &lt;p&gt;
        ///        &lt;img src=&quot;system-search.png&quot; align=&quot;middle&quot; alt=&quot;Search image&quot; /&gt;
        ///        &lt;b&gt;%Search Text%:&lt;/b&gt;&lt;br /&gt;
        ///        &lt;input type=&quot;text&quot; id=&quot;searchText&quot; style=&quot;width: 80%;&quot; name=&quot;searchText&quot; /&gt;&lt;br /&gt;
        ///        &lt;input type=&quot;button&quot; value=&quot;%Search%&quot; onclick=&quot;doSearch();&quot; id=&quot;Button1&quot; name=&quot;Button1&quot; /&gt;
        ///    &lt;/p&gt;
        ///    &lt;select id=&quot;searchResult&quot; style=&quot;width: 100%;&quot; size=&quot;20&quot; name=&quot;searchResu [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string SearchFormSimple {
            get {
                return ResourceManager.GetString("SearchFormSimple", resourceCulture);
            }
        }
    }
}