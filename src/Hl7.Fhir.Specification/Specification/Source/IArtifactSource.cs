/* 
 * Copyright (c) 2016, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.IO;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.Specification.Source
{

    public interface IArtifactSource
    {
        IEnumerable<string> ListArtifactNames();
        Stream LoadArtifactByName(string artifactName);
    }

}