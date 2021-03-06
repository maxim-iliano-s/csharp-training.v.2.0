﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using System.Windows.Forms;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
   
    [Test]
    public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(0);
            
            List<GroupData> newGroups = app.Groups.GetGroupList();

            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            
            MessageBox.Show("In AreEqual(oldGroups, newGroups) )", "GroupRemovalTest");
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}