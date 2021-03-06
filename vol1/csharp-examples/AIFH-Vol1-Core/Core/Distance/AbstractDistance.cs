// Artificial Intelligence for Humans
// Volume 1: Fundamental Algorithms
// C# Version
// http://www.aifh.org
// http://www.jeffheaton.com
//
// Code repository:
// https://github.com/jeffheaton/aifh
//
// Copyright 2013 by Jeff Heaton
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// For more information on Heaton Research copyrights, licenses
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
namespace AIFH_Vol1.Core.Distance
{
    /// <summary>
    /// This distance calculator provides a convenience calculation of vectors with 0-based index.
    /// </summary>
    public abstract class AbstractDistance : ICalculateDistance
    {
        /// <inheritdoc/>
        public double Calculate(double[] position1, double[] position2)
        {
            return Calculate(position1, 0, position2, 0, position1.Length);
        }

        /// <inheritdoc/>
        public abstract double Calculate(double[] position1, int pos1, double[] position2, int pos2, int length);
    }
}
