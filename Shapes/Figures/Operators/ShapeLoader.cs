using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Figures;

namespace Shapes.Operators
{
    public static class ShapeLoader

    {
        public static void PutIntoContainer (Box container, Shape shape)
        {
            string statusMsg;
            
            
            if (container.AddAvailable(shape))
            {
                container.emptyVolume -= shape.Volume;
                container.AddShape(shape);

                statusMsg = $"SUCCESSFULLY ADDED: [{shape.Name}] with volume [{shape.Volume}] into the Container.";
            }
            else
            {
                statusMsg = $"NOT ENOUGH SPACE: [{shape.Name}] with volume [{shape.Volume}].";
            }

            string freeContainerSpaceMsg = $"Free Container space: [{container.emptyVolume.ToString()}].";
            string usedContainerSpaceMsg = $"Used Container space: [{(container.Volume - container.emptyVolume).ToString()}]";
            string shapesInsideMsg = $"Shapes inside: {{{string.Join(',', container.Shapes.Select(s => s.Name).ToList())}}}";

            Console.WriteLine(statusMsg);
            Console.WriteLine(freeContainerSpaceMsg);
            Console.WriteLine(usedContainerSpaceMsg);
            Console.WriteLine(shapesInsideMsg);
        }
    }
}
