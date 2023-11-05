using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrimalEditor.GameProject
{
    [DataContract]
    public class Scene : ViewModelBase
    {
        private string _sceneName;
        [DataMember]
        public string SceneName
        {
            get => _sceneName;
            set
            {
                if(_sceneName != value)
                {
                    _sceneName = value;
                    OnPropertyChanged(nameof(SceneName));
                }
            }
        }

        [DataMember]
        public Project Project { get; private set; }

        public Scene(Project project, string name)
        {
            Debug.Assert(project != null);
            Project = project;
            SceneName = name;
        }
    }
}
