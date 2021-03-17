using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPractice.Design_Patterns
{
    public class AdventurerClient
    {
        private TrainingMethodsCombat _productA;
        private TrainingMethodsSkills _productB;
        public AdventurerClient(AdventurerFactory factory)
        {
            _productA = factory.CombatOptions();
            _productB = factory.SkillingOptions();
        }

    }

    public abstract class AdventurerFactory
    {
        public abstract TrainingMethodsCombat CombatOptions();
        public abstract TrainingMethodsSkills SkillingOptions();
    }

    public class NormalAdventurer : AdventurerFactory
    {
        public override TrainingMethodsCombat CombatOptions()
        {
            return new NormalCombatOptions();
        }

        public override TrainingMethodsSkills SkillingOptions()
        {
            return new NormalSkillingOptions();
        }
    }

    public class IronmanAdventurer : AdventurerFactory
    {

        public override TrainingMethodsCombat CombatOptions()
        {
            return new IronmanCombatOptions();
        }

        public override TrainingMethodsSkills SkillingOptions()
        {
            return new IronmanSkillingOptions();
        }

    }

    public abstract class TrainingMethodsCombat { }
    public class NormalCombatOptions : TrainingMethodsCombat { }
    public class IronmanCombatOptions : TrainingMethodsCombat { }


    public abstract class TrainingMethodsSkills { }
    public class NormalSkillingOptions : TrainingMethodsSkills { }
    public class IronmanSkillingOptions : TrainingMethodsSkills { }
}
