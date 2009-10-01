﻿// Copyright © 2009 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using System.Text;
using fitSharp.Machine.Model;

namespace fitSharp.Fit.Model {
    public class CellTree: TreeList<Cell> {
        public CellTree() {}

        public CellTree(Cell value): base(value) {}

        public CellTree(params string[] cells) {
            foreach (var cell in cells) AddBranch(new StringCellLeaf(cell));
        }

        public CellTree(params Tree<Cell>[] lists) {
            foreach (var list in lists) AddBranch(list);
        }

        public override string ToString() {
            var result = new StringBuilder();
            foreach (Tree<Cell> branch in Branches) {
                result.Append(branch.ToString());
            }
            return string.Format(Value == null || string.IsNullOrEmpty(Value.Text) ? "{0}" : Value.Text, result);
        }
    }
}
