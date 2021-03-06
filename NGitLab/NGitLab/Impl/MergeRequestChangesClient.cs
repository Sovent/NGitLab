﻿using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab.Impl {
    public class MergeRequestChangesClient : IMergeRequestChangesClient {
        readonly API _api;
        readonly string _changesPath;
        public MergeRequestChanges Changes {
            get { return _api.Get().To<MergeRequestChanges>(_changesPath); }
        }
        public MergeRequestChangesClient(API api, string projectPath, int mergeRequestId) {
            _api = api;
            this._changesPath = projectPath + "/merge_request/" + mergeRequestId + "/changes";
        }
    }

}
