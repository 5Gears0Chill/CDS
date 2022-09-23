using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDS.Clients.RedCap.Models
{
    /// <summary>
    /// API Action => Export, Import, Delete 
    /// </summary>
    public enum RedcapAction
    {
        /// <summary>
        /// Export Action
        /// </summary>
        /// 
        [Display(Name = "export")]
        Export,

        /// <summary>
        /// Import Action
        /// </summary>
        /// 
        [Display(Name = "import")]
        Import,
        /// <summary>
        /// Delete Action
        /// </summary>
        /// 
        [Display(Name = "delete")]
        Delete,
        /// <summary>
        /// Switch
        /// </summary>
        [Display(Name = "switch")]
        Switch,
        /// <summary>
        /// Rename
        /// </summary>
        [Display(Name = "rename")]
        Rename
    }
}
