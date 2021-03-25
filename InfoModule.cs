using Discord.Commands;
using System.Threading.Tasks;
using System.Linq;

public class CringeModule : ModuleBase<SocketCommandContext>
{

	[Command("cringe")]
	[Summary
	("That's kinda cringe, my man")]
	public async Task CringeAsync(
		string username = null)
	{
		if (username != null) {
			await Context.Guild.DownloadUsersAsync();
			var user = Context.Guild.Users.Where(u => u.Nickname == username || u.Username == username);
			if (user.Count() > 0) {
				await ReplyAsync($"<:Cringe:823641585668325417> {user.First().Mention}");
			} else {
				await ReplyAsync("User not found");
			}
		} else {
			await ReplyAsync("<:Cringe:823641585668325417>");
		}
	}
}