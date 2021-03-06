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
namespace AIFH_Vol1.Core.Learning
{
    /// <summary>
    /// A regression algorithm provides an output for the given input.  This allows the machine learning algorithm to
    /// approximate a function.
    /// </summary>
    public interface IRegressionAlgorithm: IMachineLearningAlgorithm
    {
        /// <summary>
        /// Compute the output for the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The regression output.</returns>
        double[] ComputeRegression(double[] input);
    }
}
