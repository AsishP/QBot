//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Teams.Apps.QBot.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Questions = new HashSet<Question>();
            this.TutorialGroups = new HashSet<TutorialGroup>();
            this.UserCourseRoleMappings = new HashSet<UserCourseRoleMapping>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.Guid GroupId { get; set; }
        public string PredictiveQnAServiceHost { get; set; }
        public string PredictiveQnAKnowledgeBaseId { get; set; }
        public string PredictiveQnAEndpointKey { get; set; }
        public string PredictiveQnAHttpEndpoint { get; set; }
        public string PredictiveQnAHttpKey { get; set; }
        public string PredictiveQnAKnowledgeBaseName { get; set; }
        public string PredictiveQnAConfidenceThreshold { get; set; }
        public string DeployedURL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialGroup> TutorialGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCourseRoleMapping> UserCourseRoleMappings { get; set; }
    }
}
